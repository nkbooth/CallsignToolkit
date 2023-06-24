using CallsignToolkit.Utilities;
using System.Net.Mail;
using System.Text;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZAddress : Address
    {
        public string Attention { get { return attention ?? string.Empty; } set { attention = value; } }
        public string County { get { return county ?? string.Empty; } set { county = value; } }
        public string Country { get { return country ?? string.Empty; } set { country = value; } }

        public MailAddress? EmailAddress;
        public Uri? WebAddress;

        private string attention;
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

        internal override string encodeQueryString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(this.Address1))
            {
                sb.Append('+');
                sb.Append(this.Address1);
            }
            if (!string.IsNullOrEmpty (this.Address2)) 
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
            if (!string.IsNullOrEmpty(this.County))
            {
                sb.Append('+');
                sb.Append(this.County);
            }
            if (!string.IsNullOrEmpty(this.Country))
            {
                sb.Append('+');
                sb.Append(this.Country);
            }
            return sb.ToString();
        }
    }
}
