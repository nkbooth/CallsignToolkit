using CallsignToolkit.Utilities;
using System.Net.Mail;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZAddress : Address
    {
        public string Attention { get { return attention ?? string.Empty; } set { attention = value; } }
        [AddressOrderAttribute(45)]
        public string County { get { return county ?? string.Empty; } set { county = value; } }
        public string Country { get { return country ?? string.Empty; } set { country = value; } }

        public MailAddress? EmailAddress;
        public Uri? WebAddress;

        private string? attention;
        private string? county;
        private string? country;

        public QRZAddress() { }
        public QRZAddress(string addr1, string poBoxNum, string city, string state, string zipCode) : base(addr1, poBoxNum, city, state, zipCode)
        {
        }
        public QRZAddress(string addr1, string addr2, string poBoxNum, string city, string county, string state, string zipCode, string country) : base(addr1, addr2, poBoxNum, city, state, zipCode)
        {
            County = county;
            Country = country;
        }
    }
}
