using CallsignToolkit.CallbookLookup;
using CallsignToolkit.CallbookLookup.QRZ;
using CallsignToolkitTests.IBaseTests;

namespace CallsignToolkitTests.QRZTests
{
    public class QRZLookupTests : IBaseLookupTests
    {
        public QRZLookupTests() : base(new QRZLookup(), typeof(QRZLookup))
        {
        }

        [Fact]
        public void CanSetCallsignInConstructor()
        {
            using (QRZLookup lookup = new QRZLookup("w1aw"))
            {
                Assert.Equal("w1aw", lookup.License.Callsign);
            }
        }

        [Theory]
        [InlineData("n1cck", "kc1mcn")]
        public async void AliasesSetCorrectly(string callsign, string alias)
        {
            using (QRZLookup callbook = new QRZLookup())
            {
                await callbook.PerformLookup(callsign);
                Assert.NotEmpty(callbook.Aliases ?? new List<License>());
                Assert.Equal(alias, callbook.Aliases?[0].Callsign.ToLower() ?? string.Empty);
            }
        }

        [Theory]
        [InlineData("n1cck", @"nick@n1cck.us")]
        [InlineData("w1aw", @"w1aw@arrl.org")]
        public async void EmailAddressCorrect(string callsign, string email)
        {
            using (QRZLookup callbook = new QRZLookup())
            {
                await callbook.PerformLookup(callsign);
                var addr = (QRZAddress)callbook.Address;
                Assert.Equal(email.ToLower(), addr.EmailAddress.Address.ToLower());
            }
        }

        [Fact]
        public async void ImageAddressLookup()
        {
            using (QRZLookup lookup = new QRZLookup("W1AW"))
            {
                await lookup.PerformLookup();
                Assert.Equal("http://files.qrz.com/w/w1aw/Large_W1AW_Image.jpg", lookup.ImageURL.AbsoluteUri.ToString());
            }
        }
    }
}