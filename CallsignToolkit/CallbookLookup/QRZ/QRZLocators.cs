using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZLocators : Locators
    {

        public string? FIPSCode { get { return fipsCode; } set { fipsCode = value; } }
        public string? DXCC { get { return dxcc; } set { dxcc = value; } }
        public string? TeleAreaCode { get { return teleAreaCode; } set { teleAreaCode = value; } }
        public string? CQZone { get { return cqZone; } set { cqZone = value; } }
        public string? IOTA { get { return iota; } set { iota = value; } }


        private string? fipsCode;
        private string? dxcc;
        private string? teleAreaCode;
        private string? cqZone;
        private string? iota;
    }
}