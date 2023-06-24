using CallsignToolkit.CallbookLookup.QRZ;
using CallsignToolkit.Exceptions;

namespace CallsignToolkitTests
{
    public class QRZTests
    {
        [Fact]
        public void BlankConstructorIsValid()
        {
            QRZLookup lookup = new QRZLookup();
            Assert.NotNull(lookup);
        }

        [Fact]
        public void PassedCallsignConstructorIsCorrect()
        {
            QRZLookup lookup = new QRZLookup("w1aw");
            Assert.Equal("w1aw", lookup.License.Callsign);
        }

        //[Fact]
        //public void SessionKeyIsNotEmpty()
        //{
        //    QRZLookup lookup = new QRZLookup();
        //    Assert.NotEmpty(lookup.sessionKey);
        //}

        [Fact]
        public async void N1CCKLicenseClassExtra()
        {
            QRZLookup lookup = new QRZLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("Amateur Extra", lookup.License.LicenseClass);
        }

        [Fact]
        public async void AliasesPullCorrectly()
        {
            QRZLookup lookup = new QRZLookup("n1cck");
            await lookup.PerformLookup();
            Assert.Equal("KC1MCN", lookup.Aliases[0].Callsign);
            Assert.True(lookup.Aliases.Count == 1);

            await lookup.PerformLookup("AA7BQ");
            Assert.True(lookup.Aliases.Count == 4);
            Assert.Equal("KJ6RK", lookup.Aliases[2].Callsign);
        }

        [Fact]
        public async void AddressesAreCorrect()
        {
            QRZLookup lookup = new QRZLookup("w1aw");
            await lookup.PerformLookup();
            Assert.Equal("225 MAIN ST", lookup.Address.Address1);
            Assert.Equal("NEWINGTON", lookup.Address.City);
            Assert.Equal("CT", lookup.Address.State);
            Assert.Equal("United States", lookup.Address.Country);
            Assert.Equal("Hartford", lookup.Address.County);

            await lookup.PerformLookup("n1cck");
            Assert.Equal("PO BOX 8172", lookup.Address.Address1);
        }

        [Fact]
        public async void EmailAdressLookup()
        {
            QRZLookup lookup = new("w1aw");
            await lookup.PerformLookup();
            Assert.Equal("w1aw@arrl.org", lookup.Address.EmailAddress.Address.ToLower());
            Assert.Equal("ARRL HQ OPERATORS CLUB", lookup.Address.EmailAddress.DisplayName);
        }

        [Fact]
        public async void ImageAddressLookup()
        {
            QRZLookup lookup = new("W1AW");
            await lookup.PerformLookup();
            Assert.Equal("http://files.qrz.com/w/w1aw/Large_W1AW_Image.jpg", lookup.ImageURL.AbsoluteUri.ToString());
        }

        [Fact]
        public async void BadCallsignNotFoundError()
        {
            QRZLookup lookup = new("badcallsign");
            await Assert.ThrowsAsync<CallsignNotFound>(async () => await lookup.PerformLookup());
        }

        [Fact]
        public async void ClearResultsNulls()
        {
            QRZLookup lookup = new("w1aw");
            await lookup.PerformLookup();
            
            await lookup.ClearResults();
            Assert.Null(lookup.Address);
            Assert.Null(lookup.Aliases);
            Assert.Null(lookup.AmateurName);
            Assert.Null(lookup.ImageURL);
            Assert.True(string.IsNullOrEmpty(lookup.License.Callsign));
        }
    }
}
