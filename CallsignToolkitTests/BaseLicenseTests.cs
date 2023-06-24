using CallsignToolkit.CallbookLookup;
using CallsignToolkit.CallbookLookup.HamCallDev;
using CallsignToolkit.Utilities;

namespace CallsignToolkitTests
{
    public class BaseLicenseTests
    {
        [Fact]
        public void N1CCKIsValidUSCallsign()
        {
            BaseLookup lookup = new BaseLookup();
            lookup.License.Callsign = "N1CCK";
            Assert.True(lookup.License.IsValidUSCall());
        }

        [Fact]
        public void KN7LFGDIsNotValidUSCallsign()
        {
            BaseLookup lookup = new BaseLookup();
            lookup.License.Callsign = "KN7LFGD";
            Assert.False(lookup.License.IsValidUSCall());
        }

        [Fact]
        public void RandomStringIsNotValidUSCallsign()
        {
            BaseLookup lookup = new BaseLookup();
            lookup.License.Callsign = "aposi3df";
            Assert.False(lookup.License.IsValidUSCall());

            lookup.License.Callsign = "1234567890";
            Assert.True(!lookup.License.IsValidUSCall());

            lookup.License.Callsign = "h4ds";
            Assert.False(lookup.License.IsValidUSCall());
        }

        [Fact]
        public async Task ClearRemovesDetails()
        {
            BaseLookup lookup = new BaseLookup();
            lookup.License.Callsign = "N1CCK";
            await lookup.ClearResults();
            Assert.True(string.IsNullOrEmpty(lookup.License.Callsign));
        }

        [Fact]
        public async Task AddressLatLong()
        {
            Address testAddress = new() { Address1 = "225 Main St.", City = "Newington", State = "CT", PostalCode = "06111" };
            var latLong = await testAddress.GetCoordinates();
            Assert.Equal(41.7146905, latLong.Latitude);
            Assert.Equal(-72.72851776187042, latLong.Longitude);
        }
    }
}
