using System.Xml.Serialization;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    [XmlRoot(ElementName = "Session", Namespace = "http://xmldata.qrz.com")]
    public class Session
    {

        [XmlElement(ElementName = "Key", Namespace = "http://xmldata.qrz.com")]
        public string Key { get; set; }

        [XmlElement(ElementName = "Count", Namespace = "http://xmldata.qrz.com")]
        public int Count { get; set; }

        [XmlElement(ElementName = "SubExp", Namespace = "http://xmldata.qrz.com")]
        public string SubExp { get; set; }

        [XmlElement(ElementName = "GMTime", Namespace = "http://xmldata.qrz.com")]
        public string GMTime { get; set; }

        [XmlElement(ElementName = "Remark", Namespace = "http://xmldata.qrz.com")]
        public string Remark { get; set; }

        [XmlElement(ElementName = "Error", Namespace = "http://xmldata.qrz.com")]
        public string Error { get; set; }
    }

    [XmlRoot(ElementName = "QRZDatabase", Namespace = "http://xmldata.qrz.com")]
    public class QRZDatabase
    {

        [XmlElement(ElementName = "Session", Namespace = "http://xmldata.qrz.com")]
        public Session Session { get; set; }

        [XmlElement(ElementName = "Callsign", Namespace = "http://xmldata.qrz.com")]
        public LookupResults Callsign { get; set; }

        [XmlAttribute(AttributeName = "version", Namespace = "")]
        public double Version { get; set; }

        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Callsign", Namespace = "http://xmldata.qrz.com")]
    public class LookupResults
    {
        [XmlElement(ElementName = "call", Namespace = "http://xmldata.qrz.com")]
        public string Call { get; set; }

        [XmlElement(ElementName = "aliases", Namespace = "http://xmldata.qrz.com")]
        public string Aliases { get; set; }

        [XmlElement(ElementName = "dxcc", Namespace = "http://xmldata.qrz.com")]
        public string Dxcc { get; set; }

        [XmlElement(ElementName = "fname", Namespace = "http://xmldata.qrz.com")]
        public string Fname { get; set; }

        [XmlElement(ElementName = "name", Namespace = "http://xmldata.qrz.com")]
        public string Name { get; set; }

        [XmlElement(ElementName = "addr1", Namespace = "http://xmldata.qrz.com")]
        public string Addr1 { get; set; }

        [XmlElement(ElementName = "addr2", Namespace = "http://xmldata.qrz.com")]
        public string Addr2 { get; set; }

        [XmlElement(ElementName = "state", Namespace = "http://xmldata.qrz.com")]
        public string State { get; set; }

        [XmlElement(ElementName = "zip", Namespace = "http://xmldata.qrz.com")]
        public string Zip { get; set; }

        [XmlElement(ElementName = "country", Namespace = "http://xmldata.qrz.com")]
        public string Country { get; set; }

        [XmlElement(ElementName = "lat", Namespace = "http://xmldata.qrz.com")]
        public string Lat { get; set; }

        [XmlElement(ElementName = "lon", Namespace = "http://xmldata.qrz.com")]
        public string Lon { get; set; }

        [XmlElement(ElementName = "grid", Namespace = "http://xmldata.qrz.com")]
        public string Grid { get; set; }

        [XmlElement(ElementName = "county", Namespace = "http://xmldata.qrz.com")]
        public string County { get; set; }

        [XmlElement(ElementName = "ccode", Namespace = "http://xmldata.qrz.com")]
        public string Ccode { get; set; }

        [XmlElement(ElementName = "fips", Namespace = "http://xmldata.qrz.com")]
        public string Fips { get; set; }

        [XmlElement(ElementName = "land", Namespace = "http://xmldata.qrz.com")]
        public string Land { get; set; }

        [XmlElement(ElementName = "efdate", Namespace = "http://xmldata.qrz.com")]
        public string Efdate { get; set; }

        [XmlElement(ElementName = "expdate", Namespace = "http://xmldata.qrz.com")]
        public string Expdate { get; set; }

        [XmlElement(ElementName = "class", Namespace = "http://xmldata.qrz.com")]
        public string Class { get; set; }

        [XmlElement(ElementName = "codes", Namespace = "http://xmldata.qrz.com")]
        public string Codes { get; set; }

        [XmlElement(ElementName = "email", Namespace = "http://xmldata.qrz.com")]
        public string Email { get; set; }

        [XmlElement(ElementName = "u_views", Namespace = "http://xmldata.qrz.com")]
        public string UViews { get; set; }

        [XmlElement(ElementName = "bio", Namespace = "http://xmldata.qrz.com")]
        public string Bio { get; set; }

        [XmlElement(ElementName = "biodate", Namespace = "http://xmldata.qrz.com")]
        public string Biodate { get; set; }

        [XmlElement(ElementName = "moddate", Namespace = "http://xmldata.qrz.com")]
        public string Moddate { get; set; }

        [XmlElement(ElementName = "MSA", Namespace = "http://xmldata.qrz.com")]
        public string MSA { get; set; }

        [XmlElement(ElementName = "AreaCode", Namespace = "http://xmldata.qrz.com")]
        public string AreaCode { get; set; }

        [XmlElement(ElementName = "TimeZone", Namespace = "http://xmldata.qrz.com")]
        public string TimeZone { get; set; }

        [XmlElement(ElementName = "GMTOffset", Namespace = "http://xmldata.qrz.com")]
        public string GMTOffset { get; set; }

        [XmlElement(ElementName = "DST", Namespace = "http://xmldata.qrz.com")]
        public string DST { get; set; }

        [XmlElement(ElementName = "eqsl", Namespace = "http://xmldata.qrz.com")]
        public string Eqsl { get; set; }

        [XmlElement(ElementName = "mqsl", Namespace = "http://xmldata.qrz.com")]
        public string Mqsl { get; set; }

        [XmlElement(ElementName = "cqzone", Namespace = "http://xmldata.qrz.com")]
        public string Cqzone { get; set; }

        [XmlElement(ElementName = "ituzone", Namespace = "http://xmldata.qrz.com")]
        public string Ituzone { get; set; }

        [XmlElement(ElementName = "lotw", Namespace = "http://xmldata.qrz.com")]
        public string Lotw { get; set; }

        [XmlElement(ElementName = "user", Namespace = "http://xmldata.qrz.com")]
        public string User { get; set; }

        [XmlElement(ElementName = "geoloc", Namespace = "http://xmldata.qrz.com")]
        public string Geoloc { get; set; }

        [XmlElement(ElementName = "nickname", Namespace = "http://xmldata.qrz.com")]
        public string Nickname { get; set; }

        [XmlElement(ElementName = "p_call", Namespace = "http://xmldata.qrz.com")]
        public string P_call { get; set; }

        [XmlElement(ElementName = "attn", Namespace = "http://xmldata.qrz.com")]
        public string Attn { get; set; }

        [XmlElement(ElementName = "url", Namespace = "http://xmldata.qrz.com")]
        public string Url { get; set; }

        [XmlElement(ElementName = "qslmgr", Namespace = "http://xmldata.qrz.com")]
        public string QSLMgr { get; set; }

        [XmlElement(ElementName = "image", Namespace = "http://xmldata.qrz.com")]
        public string Image { get; set; }

        [XmlElement(ElementName = "iota", Namespace = "http://xmldata.qrz.com")]
        public string Iota { get; set; }
    }
}
