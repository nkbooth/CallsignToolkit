using Newtonsoft.Json;
using CallsignToolkit.Utilities;
using System.Reflection;
using RestSharp;

namespace CallsignToolkit.CallbookLookup
{
    public class BaseLookup : IDisposable, ICallbook
    {
        public virtual License License
        {
            get
            {
                return license;
            }
            set
            {
                license = value;
            }
        }
        private License license = new();

        [ResetOnClear(true)]
        public virtual Name AmateurName
        {
            get
            {
                return amateurName;
            }
            set
            {
                amateurName = value;
            }
        }
        private Name amateurName = new();

        [ResetOnClear(true)]
        public virtual Address? Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        private Address address = new();

        [ResetOnClear(true)]
        public virtual Locators? Locators { get; set; }
        
        private RestClient api = new();
        private bool disposedValue;

        public BaseLookup() { }
        public BaseLookup(string callsign)
        {
            throw new NotImplementedException();
        }
        
        public virtual async Task ClearResults()
        {
            if (this.GetType() == typeof(License))
            {
                this.License = new License();
            }
            
            var fields = this.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).ToArray().Where(f => f != null && f.GetCustomAttribute<ResetOnClearAttribute>()?.ResetOnClear == true);                         
            foreach (FieldInfo field in fields.Where(f => f != null && f.GetCustomAttribute<ResetOnClearAttribute>()?.ResetOnClear == true))
            {
                field.SetValue(this, null);
            }            

            var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).ToArray().Where(p => p != null && p.GetCustomAttribute<ResetOnClearAttribute>()?.ResetOnClear == true);
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(this, null);
            }
            
            await Task.CompletedTask;
        }

        public virtual string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                api.Dispose();
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual Task PerformLookup()
        {
            throw new NotImplementedException();
        }

        public virtual Task PerformLookup(string callsign)
        {
            throw new NotImplementedException();
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true)]
    public class ResetOnClearAttribute : Attribute
    {
        public bool ResetOnClear { get; set; }
        public ResetOnClearAttribute(bool resetOnClear = true)
        {
            this.ResetOnClear = resetOnClear;
        }
    }
}
