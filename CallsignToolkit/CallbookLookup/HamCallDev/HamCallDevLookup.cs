using RestSharp;
using CallsignToolkit.Utilities;
using CallsignToolkit.Exceptions;
using System.Net.NetworkInformation;

namespace CallsignToolkit.CallbookLookup.HamCallDev
{
    public class HamCallDevLookup : BaseLookup, ICallbook
    {
        public override License License
        {
            get { return hamCallDevLicense; }
            set { hamCallDevLicense = (HamCallDevLicense)value; }
        }
        private HamCallDevLicense hamCallDevLicense = new();

        [ResetOnClear(true)]
        public override Name AmateurName
        {
            get { return (HamCallDevName)hamCallDevName; }
            set { hamCallDevName = (HamCallDevName)value; }
        }
        private HamCallDevName hamCallDevName = new();

        [ResetOnClear(true)]
        public HamCallDevQSL? QSLMethods;

        internal RestClient api = new RestClient("https://hamcall.dev/");

        public HamCallDevLookup() { }
        public HamCallDevLookup(string callsign)
        {
            HamCallDevLicense license = new(callsign);
            this.License = license;
        }

        public override async Task PerformLookup()
        {
            if (string.IsNullOrEmpty(this.License.Callsign) || License.Callsign == "")
            {
                throw new Exception("Callsign is required to perform lookup");
            }
            else
            {
                var results = await api.GetJsonAsync<HamCallDevRawReturn>($"{this.License.Callsign}.json");
                
                if (results.callsign == null || (string.IsNullOrEmpty(results.grant) && string.IsNullOrEmpty(results.effective) && string.IsNullOrEmpty(results.frn)))
                {
                    throw new CallsignNotFound(this.License.Callsign);
                }

                this.AmateurName = await GetNameFromResults(results);
                this.License = await GetLicenseFromResults(results);
                this.Address = await GetAddressFromResults(results);
                this.QSLMethods = await GetQSLMethodsFromResults(results);
            }
        }

        public override async Task PerformLookup(string callsign)
        {
            await this.ClearResults();
            this.License.Callsign = callsign;
            await this.PerformLookup();
        }

        public async override Task ClearResults()
        {
            api = new RestClient("https://hamcall.dev/");
            this.License = new HamCallDevLicense();
            await base.ClearResults();
        }

        private static Task<HamCallDevName> GetNameFromResults(HamCallDevRawReturn results)
        {
            HamCallDevName name = new();

            if (string.IsNullOrEmpty(results.first_name) && !string.IsNullOrEmpty(results.name))
            {
                name.FirstName = results.name;
            }
            else
            {
                name.FirstName = results.first_name;
                name.MiddleInitial = results.mi;
                name.LastName = results.last_name;
            }
            if(string.IsNullOrEmpty(name.MiddleInitial))
            {
                Name tempName = Name.SeperateMiddleInitialFromFirstName(name);
            }
            return Task.FromResult((HamCallDevName)name);
        }

        private Task<HamCallDevLicense> GetLicenseFromResults(HamCallDevRawReturn results)
        {
            HamCallDevLicense license = new()
            {
                Callsign = this.License.Callsign
            };
            if (results.@class == "")
            {
                license.LicenseClass = "Club";
            }
            else
            {
                license.LicenseClass = results.@class;
            }
            
            DateTime.TryParse(results.grant, out license.GrantDate);
            DateTime.TryParse(results.effective, out license.EffectiveDate);
            DateTime.TryParse(results.expiration, out license.ExpirationDate);
            int.TryParse(results.frn, out license.FRN);
            int.TryParse(results.file_number, out license.FileNumber);
            int.TryParse(results.license_key, out license.LicenseKey);

            if (results.dmr_id != null)
            {
                foreach (int dmrID in results.dmr_id)
                {
                    license.DMRID.Add(dmrID);
                }
            }
            return Task.FromResult(license);
        }

        private static Task<Address> GetAddressFromResults(HamCallDevRawReturn results) 
        {
            Address address = new()
            {
                Address1 = results.address,
                City = results.city,
                State = results.state,
                PostalCode = results.zip,
                POBoxNumber = results.po_box
            };

            address = Address.SanitizePostCode(address);
            return Task.FromResult(address);
        }

        private static Task<HamCallDevQSL> GetQSLMethodsFromResults(HamCallDevRawReturn results)
        {
            HamCallDevQSL qSLMethods = new();
            DateTime.TryParse(results.last_lotw, out qSLMethods.LastLOTWUpload);
            return Task.FromResult(qSLMethods);
        }
    }
}
