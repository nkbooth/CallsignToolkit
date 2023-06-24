using System.Net.Mail;
using RestSharp;
using CallsignToolkit.Utilities;
using CallsignToolkit.Exceptions;
using static System.Net.Mime.MediaTypeNames;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZLookup : BaseLookup, ICallbook
    {
        public new QRZName? AmateurName;

        #region Callsigns
        public new QRZLicense License = new QRZLicense();
        public License? PreviousCallsign;
        public List<License>? Aliases;
        #endregion

        #region Locators
        public new QRZAddress? Address;
        // public TimeZoneInfo? TimeZone = new();
        #endregion

        #region QSL Details
        public QSLMethods? QSLMethods;
        #endregion

        #region Misc
        public Uri? ImageURL;
        #endregion

        #region API Details
        private string? username;
        private string? password;
        private string sessionKey = string.Empty;
        RestClient api = new RestClient(new RestClientOptions("https://xmldata.qrz.com/xml/1.31"));
        #endregion

        #region Constructors
        public QRZLookup()
        {
            this.username = Environment.GetEnvironmentVariable("QRZ_USER");
            this.password = Environment.GetEnvironmentVariable("QRZ_PASSWORD");
            this.refreshSessionKey().Wait();
        }
        public QRZLookup(string callsign)
        {
            License license = new QRZLicense()
            {
                Callsign = callsign
            };
            this.License = (QRZLicense)license;

            this.username = Environment.GetEnvironmentVariable("QRZ_USER");
            this.password = Environment.GetEnvironmentVariable("QRZ_PASSWORD");
        }
        public QRZLookup(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.refreshSessionKey().Wait();
        }
        public QRZLookup(string callsign, string username, string password)
        {
            License license = new License()
            {
                Callsign = callsign
            };
            this.License = (QRZLicense)license;
            this.username = username;
            this.password = password;
        }
        #endregion

        public async Task PerformLookup()
        {
            if (this.sessionKey == string.Empty)
            {
                await refreshSessionKey();
            }

            var request = new RestRequest();
            request.AddOrUpdateParameter("s", this.sessionKey);
            request.AddOrUpdateParameter("callsign", this.License.Callsign);
            request.AddHeader("Content-Type", "application/xml");

            var response = await api.ExecuteAsync<QRZDatabase>(request, Method.Get);
            if (response.IsSuccessful == false || response.Data == null)
            {
                throw new Exception("Error accessing QRZ API.", response.ErrorException);
            }
            else if (response.Data.Session.Error != null)
            {
                switch (response.Data.Session.Error)
                {
                    case string c when c.Contains("Session Timeout"):
                        await refreshSessionKey();
                        await PerformLookup();
                        break;
                    case string b when b.Contains("Invalid Session Key"):
                        await refreshSessionKey();
                        await PerformLookup();
                        break;
                    case string a when a.Contains("Not found:"):
                        throw new CallsignNotFound(this.License.Callsign);                        
                    default:
                        throw new Exception("QRZ XML API: " + response.Data.Session.Error);
                }
            }
            else if (response.Data.Session.SubExp.ToLower() == "non-subscriber")
            {
                throw new Exception("QRZ XML API: Non-subscriber access denied.");
            }

            this.AmateurName = await GetAmateurNameFromResults(response.Data);
            this.License = await GetLicenseFromResults(response.Data);
            this.PreviousCallsign = await GetPreviousCallsignFromResults(response.Data);
            this.Aliases = await GetAliasesFromResults(response.Data);
            this.Address = await GetAddressFromResults(response.Data);
            this.QSLMethods = await GetQSLMethodsFromResults(response.Data);
            this.ImageURL = await GetImageURLFromResults(response.Data);
        }

        public async Task PerformLookup(string callsign)
        {
            QRZLicense license = new QRZLicense();
            license.Callsign = callsign;
            this.License = license;
            await PerformLookup();
        }

        internal async Task refreshSessionKey()
        {
            var request = new RestRequest(string.Format("?username={0};password={1}", this.username, this.password));
            request.AddHeader("Content-Type", "application/xml");
            
            var response = await api.ExecuteAsync<QRZDatabase>(request, Method.Get);
            
            if (response.IsSuccessful == false)
            {
                throw new Exception("Error accessing QRZ API.", response.ErrorException);
            }
            else if (response.Data.Session.SubExp.ToLower() == "non-subscriber")
            {
                throw new Exception("QRZ XML API: Non-subscriber access denied.");
            }
            this.sessionKey = response.Data.Session.Key;
        }

        public async override Task ClearResults()
        {
            this.AmateurName = null;
            this.License = new QRZLicense();
            this.PreviousCallsign = null;
            this.Aliases = null;
            this.Address = null;
            this.QSLMethods = null;
            this.ImageURL = null;
            api = new RestClient(new RestClientOptions("https://xmldata.qrz.com/xml/1.31"));
            await Task.CompletedTask;
        }

        private static Task<QRZName> GetAmateurNameFromResults(QRZDatabase results)
        {
            QRZName qRZName = new()
            { 
                FirstName = results.Callsign.Fname,
                LastName = results.Callsign.Name,
                Nickname = results.Callsign.Nickname
            };
            
            return Task.FromResult<QRZName>(qRZName);
        }
        
        private static Task<QRZLicense> GetLicenseFromResults(QRZDatabase results) 
        {
            QRZLicense license = new()
            { 
                Callsign = results.Callsign.Call,
                LicenseClass = results.Callsign.Class
            };

            DateTime.TryParse(results.Callsign.Efdate, out DateTime grantDate);
            license.GrantDate = grantDate;

            DateTime.TryParse(results.Callsign.Expdate, out DateTime expirationDate);
            license.ExpirationDate = expirationDate;
            
            return Task.FromResult(license);
        }

        private static Task<License> GetPreviousCallsignFromResults(QRZDatabase results)
        {
            License license = new()
            {
                Callsign = results.Callsign.P_call
            };
            return Task.FromResult(license);
        }

        private static Task<List<License>> GetAliasesFromResults(QRZDatabase results)
        {
            if(results.Callsign.Aliases == null)
            {
                return Task.FromResult<List<License>>(null);
            }
            else
            {
                List<License> aliases = new List<License>();
                string[] calls = results.Callsign.Aliases.Split(',');

                foreach (string call in calls)
                {
                    aliases.Add(new License(call));
                }
                return Task.FromResult(aliases);
            }
        }

        private static Task<QRZAddress> GetAddressFromResults(QRZDatabase results)
        {
            QRZAddress address = new()
            {
                Attention = results.Callsign.Attn,
                Address1 = results.Callsign.Addr1,
                City = results.Callsign.Addr2,
                State = results.Callsign.State,
                PostalCode = results.Callsign.Zip,
                County = results.Callsign.County,
                Country = results.Callsign.Country
            };

            if(!string.IsNullOrEmpty(results.Callsign.Email))
            {
                MailAddress email = new MailAddress(results.Callsign.Email, results.Callsign.Name);
                address.EmailAddress = email;
            }

            if (!string.IsNullOrEmpty(results.Callsign.Url))
            {
                Uri webaddress = new Uri(results.Callsign.Url);
                address.WebAddress = webaddress;
            }

            return Task.FromResult(address);
        }

        private static Task<QSLMethods> GetQSLMethodsFromResults(QRZDatabase results)
        {
            QSLMethods qslMethods = new()
            {
                UseEQSL = results.Callsign.Eqsl == "1" ? true : false,
                UseLOTW = results.Callsign.Lotw == "1" ? true : false,
                UsePaperQSL = results.Callsign.Mqsl == "Y" ? true : false,
                QSLManager = results.Callsign.QSLMgr
            };

            return Task.FromResult(qslMethods);
        }

        private static Task<Uri> GetImageURLFromResults(QRZDatabase results)
        {
            Uri image = results.Callsign.Image == null ? new Uri("about:blank") : new Uri(results.Callsign.Image);
            return Task.FromResult(image);
        }
    }
}
