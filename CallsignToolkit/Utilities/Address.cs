using RestSharp;
using System.Text;

namespace CallsignToolkit.Utilities
{
    public class Address : IDisposable
    {
        [AddressOrderAttribute(10)]
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
        [AddressOrderAttribute(20)]
        public string Address2 { get { return address2 ?? string.Empty; } set { address2 = value; } }
        [AddressOrderAttribute(30)]
        public string POBoxNumber { get { return poBoxNumber ?? string.Empty; } set { poBoxNumber = value ?? string.Empty; } }
        [AddressOrderAttribute(40)]
        public string City { get { return city ?? string.Empty; } set { city = value; } }
        [AddressOrderAttribute(50)]
        public string State { get { return state ?? string.Empty; } set { state = value; } }
        [AddressOrderAttribute(60)]
        public string PostalCode { get { return postalCode ?? string.Empty; } set { postalCode = value; } }


        protected string? address1;
        protected string? address2;
        protected string? poBoxNumber;
        protected string? city;
        protected string? state;
        protected string? postalCode;
        private bool disposedValue;

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

        public static Address SanitizePostCode(Address addr)
        {
            if (!string.IsNullOrEmpty(addr.postalCode))
            {
                addr.postalCode.Replace("-", "");
                if (addr.postalCode.All(c => c >= '0' && c <= '9'))
                {
                    if(addr.postalCode.Length > 5)
                        addr.postalCode = addr.postalCode.Insert(5, "-");
                }
            }
            return addr;
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class AddressOrderAttribute : Attribute
    {
        public AddressOrderAttribute(int order)
        {
            this.Order = order;
        }
        public int Order { get; set; }
    }
}
