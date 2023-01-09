using System.Text.Json;
using N1CCK.CallsignValidators;
using System.Xml.Linq;
using System;

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
            if (string.IsNullOrEmpty(this.sessionKey))
            {
                this.setSessionKey();
                return this.sessionKey;
            }
            else
            {
                return this.sessionKey;
            }
        }
    }
    private string sessionKey = string.Empty;
    private void setSessionKey()
    {
        string QRZUsername = Environment.GetEnvironmentVariable("QRZ_USERNAME");
        string QRZPassword = Environment.GetEnvironmentVariable("QRZ_PASSWORD");
        HttpResponseMessage response = new HttpResponseMessage();

        try
        {
            var client = new HttpClient();
            response = client.GetAsync($"https://xmldata.qrz.com/xml/current/?username={QRZUsername};password={QRZPassword}").Result;
        }
        catch (Exception e)
        {
            throw new Exception("QRZ XML API Error: " + e.Message);
        }

        if (response.IsSuccessStatusCode)
        {
            try
            {
                string? content = response.Content.ReadAsStringAsync().Result;
                var doc = XDocument.Parse(content);
                if (doc.Descendants("Error").Any())
                {
                    throw new Exception("QRZ XML API Error: " + doc.Descendants("Error").FirstOrDefault().Value);
                }
                else
                {
                    var sessionKey = doc.Descendants("Session").FirstOrDefault().Value;
                    this.sessionKey = sessionKey;
                }
            }
            catch (Exception e)
            {
                throw new Exception("QRZ XML API Error: " + e.Message);
            }
        }
    }

    public string GetCallInfo(string callsign)
    {
        // return JSON formatted string of call info
        string results = string.Empty;

        var client = new HttpClient();
        HttpResponseMessage response = new HttpResponseMessage();
        try
        {
            response = client.GetAsync($"https://xmldata.qrz.com/xml/current/?s={this.SessionKey}&callsign={callsign}").Result;
        }
        catch (Exception ex)
        {
            throw new Exception("QRZ XML API Error: " + ex.Message);
        }

        if (response.IsSuccessStatusCode)
        {
            string? content = response.Content.ReadAsStringAsync().Result;
            var doc = XDocument.Parse(content);
            if (doc.Descendants("Error").FirstOrDefault().ToString() == "Session expired")
            {
                this.setSessionKey();
                return this.GetCallInfo(callsign);
            }
            else if (doc.Descendants("Error").Any())
            {
                throw new Exception("QRZ XML API Error: " + doc.Descendants("Error").FirstOrDefault().Value);
            }
            else
            {
                results = JsonSerializer.Serialize(doc.Descendants("Callsign").FirstOrDefault());
            }
        }
        else
        {
            throw new Exception("QRZ XML API Error: " + response.StatusCode.ToString());
        }
        return results;
    }
}