using RestSharp;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace CallsignToolkit.Utilities
{
    public class Locators
    {
        public LatLong GeoCoordinates;
        public string? GridSquare;
        public DXInfomration DXInformation;

        public static async Task<LatLong> GetLatLong(Address address)
        {
            RestRequest request = new RestRequest("https://geocode.maps.co/search", Method.Get);
            
            if (address == null)
                return new LatLong();

            string query = Locators.EncodeGeocodeQueryString(address);

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
                    try
                    {
                        var lat = json[0]["lat"];
                        var lng = json[0]["lon"];
                        return new LatLong(lat.ToString(), lng.ToString());
                    }
                    catch (Exception) 
                    {
                        return new LatLong();
                    }
                }
            }
            return new LatLong();
        }

        internal static string EncodeGeocodeQueryString(Address addr)
        {
            StringBuilder sb = new StringBuilder();

            Type type = addr.GetType();
            PropertyInfo[] properties = type.GetProperties().Where(p => p.GetCustomAttribute<AddressOrderAttribute>() != null).OrderBy(p => p.GetCustomAttribute<AddressOrderAttribute>()?.Order).ToArray();
            
            foreach (PropertyInfo property in properties)
            {
                if (!string.IsNullOrEmpty(property.GetValue(addr, null).ToString()) && !property.GetValue(addr, null).ToString().ToLower().Contains("suite"))
                {
                    if (sb.Length > 0)
                        sb.Append('+');
                        sb.Append(property.GetValue(addr, null).ToString().Replace(' ', '+'));
                }
            }
            return sb.ToString();
        }
    }
}
