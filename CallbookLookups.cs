using Newtonsoft.Json;
using N1CCK.CallsignValidators;
using System.Xml.Linq;

namespace N1CCK.CallbookLookups;

public static class HamCall
{
    public static string GetCallInfo(string callsign)
    {
        if (!CallsignValidation.IsValidCallsign(callsign))
        {
            return string.Empty;
        }

        var client = new HttpClient();
        var response = client.GetAsync($"https://hamcall.dev/{callsign}.json").Result;
        if (response.IsSuccessStatusCode)
        {
            string? content = response.Content.ReadAsStringAsync().Result;
            return content;
        }
        else
        {
            return string.Empty;
        }
    }
}

public class QRZXML
{
    public string SessionKey
    {
        get
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                setSessionKey();
                return sessionKey;
            }
            else
            {
                return sessionKey;
            }
        }
    }
    private string sessionKey = new String(string.Empty);
    
    private void setSessionKey()
    {
        string? QRZUsername = Environment.GetEnvironmentVariable("QRZ_USERNAME");
        string? QRZPassword = Environment.GetEnvironmentVariable("QRZ_PASSWORD");
        HttpResponseMessage response = new HttpResponseMessage();

        try
        {
            var client = new HttpClient();
            string link = string.Format("https://xmldata.qrz.com/xml/current/?username={0}&password={1}", QRZUsername, QRZPassword);
            response = client.GetAsync(link).Result;
        }
        catch (Exception e)
        {
            throw new Exception("Error setting session key: " + e.Message);
        }

        if (response.IsSuccessStatusCode)
        {
            try
            {
                string? content = response.Content.ReadAsStringAsync().Result;
                var doc = XDocument.Parse(content);

                XElement? error = doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Error");
                if (error != null)
                {
                    throw new Exception(error.Value);
                }
                else
                {
                    XElement? key = doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Key");
                    this.sessionKey = key.Value;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error setting session key: " + e.Message);
            }
        }
    }

    public string GetCallInfo(string callsign)
    {
        string results = string.Empty;

        var client = new HttpClient();
        HttpResponseMessage response = new HttpResponseMessage();
        try
        {
            response = client.GetAsync($"https://xmldata.qrz.com/xml/current/?s={this.SessionKey}&callsign={callsign}").Result;
        }
        catch (Exception ex)
        {
            throw new Exception("QRZ XML API Error getting call data: " + ex.Message);
        }

        if (response.IsSuccessStatusCode)
        {
            string? content = response.Content.ReadAsStringAsync().Result;
            var doc = XDocument.Parse(content);

            var errors = doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Error");
            
            if (errors != null)
            {
                if (doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Error").Value == "Session expired")
                {
                    this.setSessionKey();
                    return this.GetCallInfo(callsign);
                }
                else
                {
                    throw new Exception("QRZ XML API Error: " + doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Error").Value);
                }
            }
            else
            {
                results = JsonConvert.SerializeXNode(doc.DescendantNodes().OfType<XElement>().FirstOrDefault(x => x.Name.LocalName == "Callsign"));
            }
        }
        else
        {
            throw new Exception("QRZ XML API Error: " + response.StatusCode.ToString());
        }
        return results;
    }
}