using RestSharp;
using System.Text;

namespace CallsignToolkit.Utilities
{
    public class Address
    {
        public string Address1
        {
            get
            {
                if (!string.IsNullOrEmpty(poBoxNumber))
                {
                    if (string.IsNullOrEmpty(address1))
                    {
                        return string.Format("PO Box {0}", poBoxNumber);
                    }
                    else
                    {
                        return string.Format("PO Box {0}, {1}", poBoxNumber, address1);
                    }
                }
                else
                {
                    return address1 ?? string.Empty;
                }
            }
            set { address1 = value; }
        }
        public string Address2 { get { return address2 ?? string.Empty; } set { address2 = value; } }
        public string POBoxNumber { get { return poBoxNumber ?? string.Empty; } set { poBoxNumber = value ?? string.Empty; } }
        public string City { get { return city ?? string.Empty; } set { city = value; } }
        public string State { get { return state ?? string.Empty; } set { state = value; } }
        public string PostalCode { get { return postalCode ?? string.Empty; } set { postalCode = value; } }


        private string? address1;
        private string? address2;
        private string? poBoxNumber;
        private string? city;
        private string? state;
        private string? postalCode;

        public Address() { }
        public Address(string addr1, string addr2, string city, string state, string zipCode)
        {
            this.Address1 = addr1;
            this.Address2 = addr2;
            this.City = city;
            this.State = state;
            this.PostalCode = zipCode;
        }
        public Address(string poBoxNum, string city, string state, string zipCode)
        {
            this.POBoxNumber = poBoxNum;
            this.City = city;
            this.State = state;
            this.PostalCode = zipCode;
        }
        public Address(string addr1, string addr2, string poBoxNum, string city, string state, string zipCode)
        {
            this.Address1 = addr1;
            this.Address2 = addr2;
            this.POBoxNumber = poBoxNum;
            this.City = city;
            this.State = state;
            this.PostalCode = zipCode;
        }

        public virtual async Task<LatLong> GetCoordinates()
        {
            RestRequest request = new RestRequest("https://geocode.maps.co/search", Method.Get);
            string query = encodeQueryString();
            
            request.AddParameter("q", query, false);
            request.AddOrUpdateHeader("Content-Type", "application/json");
            request.AddOrUpdateHeader("Application", "n1cck-toolkit");

            var response = await new RestClient().ExecuteAsync(request);
            if (response.IsSuccessful && response.Content != null)
            {
                var result = response.Content;
                var json = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
                
                if (json != null)
                {
                    var lat = json[0]["lat"];
                    var lng = json[0]["lon"];

                    return new LatLong(lat.ToString(), lng.ToString());
                }
            }
            return new LatLong();
        }

        internal virtual string encodeQueryString()
        {
            StringBuilder sb = new StringBuilder();
            if(!string.IsNullOrEmpty(this.Address1))
            {
                sb.Append('+');
                sb.Append(this.Address1);
            }
            if(!string.IsNullOrEmpty(this.Address2))
            {
                sb.Append('+');
                sb.Append(this.Address2);
            }
            if (!string.IsNullOrEmpty(this.City))
            {
                sb.Append('+');
                sb.Append(this.City);
            }
            if (!string.IsNullOrEmpty(this.State))
            {
                sb.Append('+');
                sb.Append(this.State);
            }
            if (!string.IsNullOrEmpty(this.PostalCode))
            {
                sb.Append('+');
                sb.Append(this.PostalCode);
            }
            return sb.ToString();
        }
    }
}
