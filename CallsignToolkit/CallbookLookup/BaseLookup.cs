using Newtonsoft.Json;
using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup
{
    public class BaseLookup
    {
        public License License = new License();
        public Name? AmateurName;
        public Address? Address;
        
        public virtual async Task ClearResults()
        {
            this.License = new License();
            this.AmateurName = null;
            this.Address = null;
            await Task.CompletedTask;
        }

        public virtual string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
