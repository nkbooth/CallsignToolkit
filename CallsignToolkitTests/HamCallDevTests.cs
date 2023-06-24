using CallsignToolkit.CallbookLookup.HamCallDev;
using CallsignToolkit.Exceptions;

namespace CallsignToolkitTests
{
    public class HamCallDevTests
    {
        [Fact]
        public void CanSetCallsignInConstructor()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            Assert.Equal("n1cck", lookup.License.Callsign);
        }

        [Fact]
        public void CanSetCallsignInProperty()
        {
            HamCallDevLookup lookup = new HamCallDevLookup();
            lookup.License.Callsign = "n1cck";
            Assert.Equal("n1cck", lookup.License.Callsign);
        }

        [Fact]
        public async void PerformLookupFirstNameMatches()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("Nicholas", lookup.AmateurName.FirstName);
        }

        [Fact]
        public async void PerformLookupLastNameMatches()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("Booth", lookup.AmateurName.LastName);
        }

        [Fact]
        public async void PerformLookupFullNameMatches()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("Nicholas K. Booth", lookup.AmateurName.FullName);
        }

        [Fact]
        public async void AddressOneIncludesPOBox()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("PO Box 8172", lookup.Address.Address1);
        }

        [Fact]
        public async void ClearRemovesDetails()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            await lookup.ClearResults();

            Assert.True(string.IsNullOrEmpty(lookup.License.Callsign));
            Assert.Null(lookup.AmateurName);
            Assert.Null(lookup.Address);
            Assert.Null(lookup.QSLMethods);
            Assert.True(lookup.License.DMRID.Count == 0);
        }

        [Fact]
        public async void ReloadCallsignIsClean()
        {
            HamCallDevLookup lookup = new HamCallDevLookup("n1cck");
            await lookup.PerformLookup();
            Assert.True(lookup.AmateurName.FullName == "Nicholas K. Booth");

            await lookup.PerformLookup("w1aw");
            Assert.True(lookup.AmateurName.FirstName == "ARRL HQ OPERATORS CLUB");
            Assert.True(lookup.License.Callsign.ToUpper() == "W1AW");
        }

        [Fact]
        public async void W1AWHasTwoDMRIds()
        {
            HamCallDevLookup lookup = new("w1aw");
            await lookup.PerformLookup();

            Assert.Equal(2, lookup.License.DMRID.Count);
            Assert.Equal(310938, lookup.License.DMRID[1]);
        }

        [Fact]
        public async void ClubCallsNameCorrectly()
        {
            HamCallDevLookup lookup = new("w1aw");
            await lookup.PerformLookup();
            Assert.Equal("ARRL HQ OPERATORS CLUB", lookup.AmateurName.FullName);
        }

        [Fact]
        public async void CallsignNotFoundHandled()
        {            
            HamCallDevLookup lookup = new("W1AW");
            await lookup.PerformLookup();
            Assert.Equal("ARRL HQ OPERATORS CLUB", lookup.AmateurName.FullName);

            await Assert.ThrowsAsync<CallsignNotFound>(() => lookup.PerformLookup("n45tf"));
        }
    }
}
