using System.Text.RegularExpressions;

namespace N1CCK.CallsignValidators;
public static class CallsignValidation
{
    private static string[] callFilterRules = new string[] {
            "(?:[KNW][0-9][A-Z]{3})",
            "(?:[KW][A-Z][0-9][A-Z]{3})",
            "(?:[KNW][A-Z]?[0-9][A-Z]{1,2})",
            "(?:(?:(?:A[A-L])|(?:[KNW][A-Z]))[0-9][A-Z]{1,2})",
            "(?:(?:(?:[KNW]L)|(?:[NW]P)|(?:[KNW]H))[0-9][A-Z]{2})"
        };

    private static string callsignRegex
    {
        get
        {
            return string.Join("|", callFilterRules);
        }
        set { }
    }


    public static bool IsValidCallsign(string callsign)
    {
        return Regex.IsMatch(callsign, callsignRegex, RegexOptions.IgnoreCase);
    }

    public static string GetCallsignFromString(string callsign)
    {
        var matches = Regex.Matches(callsign, callsignRegex, RegexOptions.IgnoreCase);
        if (matches.Count > 0)
        {
            return matches[0].Value;
        }
        else
        {
            return string.Empty;
        }
    }
}

public static class GlaargVeNumberValidation
{
    private static string GlaargVeNumberRegex = @"(?:[0-9]{1,4}[GEge])";

    public static string GetGlaargVENumber(string text)
    {
        var matches = Regex.Matches(text, GlaargVeNumberRegex);
        if (matches.Count > 0)
        {
            return matches[0].Value;
        }
        else
        {
            return string.Empty;
        }
    }

    public static string GetGlaargVENumberFromString(string text)
    {
        var matches = Regex.Matches(text, GlaargVeNumberRegex);
        if (matches.Count > 0)
        {
            return matches[0].Value;
        }
        else
        {
            return string.Empty;
        }
    }
}