using RestSharp;
using CallsignToolkit.Utilities;
using CallsignToolkit.Exceptions;
using System.Net.NetworkInformation;

namespace CallsignToolkit.CallbookLookup.HamCallDev
{
    public class HamCallDevLookup : BaseLookup, ICallbook
    {
        public new HamCallDevLicense License = new HamCallDevLicense();
        public new HamCallDevName? AmateurName;

        public HamCallDevQSL? QSLMethods;

        internal RestClient api = new RestClient("https://hamcall.dev/");

        public HamCallDevLookup() { }
        public HamCallDevLookup(string callsign)
        {
            HamCallDevLicense license = new(callsign);
            this.License = license;
        }

        public async Task PerformLookup()
        {
            if (string.IsNullOrEmpty(this.License.Callsign) || License.Callsign == "")
            {
                throw new Exception("Callsign is required to perform lookup");
            }
            else
            {
                var results = await api.GetJsonAsync<HamCallDevRawReturn>($"{this.License.Callsign}.json");
                
                if (results.callsign == null)
                {
                    throw new CallsignNotFound(this.License.Callsign);
                }

                this.AmateurName = await GetName(results);
                this.License = await GetLicense(results);
                this.Address = await GetAddress(results);
                this.QSLMethods = await GetQSLMethods(results);
            }
        }

        public async Task PerformLookup(string callsign)
        {
            await this.ClearResults();
            this.License.Callsign = callsign;
            await this.PerformLookup();
        }

        public async override Task ClearResults()
        {
            License = new HamCallDevLicense();
            AmateurName = null;
            QSLMethods = null;
            Address = null;
            api = new RestClient("https://hamcall.dev/");
            await Task.CompletedTask;
        }

        private static Task<HamCallDevName> GetName(HamCallDevRawReturn results)
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
            return Task.FromResult(name);
        }

        private Task<HamCallDevLicense> GetLicense(HamCallDevRawReturn results)
        {
            HamCallDevLicense license = new()
            {
                Callsign = this.License.Callsign,
                LicenseClass = results.@class
            };
            DateTime.TryParse(results.grant, out license.GrantDate);
            DateTime.TryParse(results.effective, out license.EffectiveDate);
            DateTime.TryParse(results.expiration, out license.ExpirationDate);
            int.TryParse(results.frn, out license.FRN);
            int.TryParse(results.file_number, out license.FileNumber);
            int.TryParse(results.license_key, out license.LicenseKey);

            foreach (int dmrID in results.dmr_id)
            {
                license.DMRID.Add(dmrID);
            }
            return Task.FromResult(license);
        }

        private static Task<Address> GetAddress(HamCallDevRawReturn results) 
        {
            Address address = new()
            {
                Address1 = results.address,
                City = results.city,
                State = results.state,
                PostalCode = results.zip,
                POBoxNumber = results.po_box
            };

            return Task.FromResult(address);
        }

        private static Task<HamCallDevQSL> GetQSLMethods(HamCallDevRawReturn results)
        {
            HamCallDevQSL qSLMethods = new();
            DateTime.TryParse(results.last_lotw, out qSLMethods.LastLOTWUpload);
            return Task.FromResult(qSLMethods);
        }
    }
}
