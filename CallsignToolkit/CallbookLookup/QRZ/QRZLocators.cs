using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZLocators : Locators
    {

        public string FIPSCode { get { return fipsCode ?? string.Empty; } set { fipsCode = value; } }
        public string TeleAreaCode { get { return teleAreaCode ?? string.Empty; } set { teleAreaCode = value; } }
        public string IOTA { get { return iota ?? string.Empty; } set { iota = value; } }


        private string? fipsCode;
        private string? teleAreaCode;
        private string? iota;
    }
}