using System.Runtime.Serialization;

namespace CallsignToolkit.Utilities
{
    [DataContract]
    public enum DXInfomration
    {
        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CA")]
        [CQZones(new int[] { 1, 2, 3, 4, 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 2, 3, 4, 9, 75 })]
        [PrefixRegex("^V[A-GOY][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Canada = 1,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("")]
        [OutgoingQSLService(false)]
        AbuAilIslands = 2,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("AF")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 40 })]
        [PrefixRegex("^(YA|T6)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Afghanistan = 3,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MU")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^3B[67][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        AgalégaandSaintBrandon = 4,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("AX")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^OH0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ÅlandIslands = 5,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 1 })]
        [Deleted(false)]
        [ITUZones(new int[] { 1, 2 })]
        [PrefixRegex("^[KANW]L[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Alaska = 6,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("AL")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^ZA[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Albania = 7,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 39 })]
        [Deleted(true)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^VQ9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Aldabra = 8,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AS")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^KH8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AmericanSamoa = 9,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 68 })]
        [PrefixRegex(@"^FT\/Z[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AmsterdamandSaintPaulIslands = 10,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IN")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^VU4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AndamanandNicobarIslands = 11,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("AI")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^VP2E[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Anguilla = 12,

        [EnumMember]
        [ContinentName("AN")]
        [ISOCountryCode("AQ")]
        [CQZones(new int[] { 12, 13, 29, 30, 32, 38, 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 67, 69, 70, 71, 72, 73, 74 })]
        [PrefixRegex("^(CE9|KC4)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Antarctica = 13,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("AM")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^EK[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Armenia = 14,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("RU")]
        [CQZones(new int[] { 16, 17, 18, 19, 23 })]
        [Deleted(false)]
        [ITUZones(new int[] { 20, 21, 22, 23, 24, 25, 26, 30, 31, 32, 33, 34, 35, 75 })]
        [PrefixRegex("^(U[A-I][089]|R[A-Z])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AsiaticRussia = 15,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NZ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^ZL9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NewZealandSubantarcticIslands = 16,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("VE")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^YV0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        IsladeAves = 17,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("AZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^4[JK][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Azerbaijan = 18,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 8 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^HK0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        BajoNuevo = 19,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("UM")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH1[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        HowlandandBakerIslands = 20,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ES")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^E[A-H]6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BalearicIslands = 21,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PW")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 64 })]
        [PrefixRegex("^T8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Palau = 22,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 39 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("")]
        [OutgoingQSLService(false)]
        BlenheimReef = 23,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("BV")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 67 })]
        [PrefixRegex("^3Y[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BouvetIsland = 24,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^ZC5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        BritishNorthBorneo = 25,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 37 })]
        [Deleted(true)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^VQ6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        BritishSomaliland = 26,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("BY")]
        [CQZones(new int[] { 16 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^E[U-W][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Belarus = 27,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 7 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KZ5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PanamaCanalZone = 28,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ES")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 36 })]
        [PrefixRegex("^E[A-H]8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CanaryIslands = 29,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^PK6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        CelebesandtheMoluccaIslands = 30,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("KI")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^T31[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PhoenixIslands = 31,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ES")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^E[A-H]9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CeutaandMelilla = 32,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("IO")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^VQ9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ChagosIslands = 33,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NZ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^ZL7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ChathamIslands = 34,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("CX")]
        [CQZones(new int[] { 29 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^VK9X[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ChristmasIsland = 35,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("PF")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 10 })]
        [PrefixRegex("^(FO|TX)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ClippertonIsland = 36,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CR")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^TI9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CocosIsland = 37,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("CC")]
        [CQZones(new int[] { 29 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^VK9C[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CocosKeelingIslands = 38,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GR")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^(SV|J4)9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Crete = 40,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 68 })]
        [PrefixRegex(@"^FT\/W[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CrozetIslands = 41,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 22 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^CR8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        DamanandDiu = 42,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("PR")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KP5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        DesecheoIsland = 43,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 39 })]
        [Deleted(true)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^VQ9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        DesrochesIsland = 44,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GR")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^(SV|J4)5[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Dodecanese = 45,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("MY")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^9M[68][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        EastMalaysia = 46,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CL")]
        [CQZones(new int[] { 12 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^CE0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        EasterIsland = 47,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("KI")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61, 63 })]
        [PrefixRegex("^T32[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        LineIslands = 48,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GQ")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47 })]
        [PrefixRegex("^3C[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        EquatorialGuinea = 49,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("MX")]
        [CQZones(new int[] { 6 })]
        [Deleted(false)]
        [ITUZones(new int[] { 10 })]
        [PrefixRegex("^X[A-I][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Mexico = 50,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ER")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^E3[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Eritrea = 51,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("EE")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^ES[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Estonia = 52,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ET")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^ET[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Ethiopia = 53,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("RU")]
        [CQZones(new int[] { 16 })]
        [Deleted(false)]
        [ITUZones(new int[] { 19, 20, 29, 30 })]
        [PrefixRegex("^(U[A-I][1-7]|R[A-Z])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        EuropeanRussia = 54,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 39 })]
        [Deleted(true)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^VQ9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        FarquharGroup = 55,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BR")]
        [CQZones(new int[] { 11 })]
        [Deleted(false)]
        [ITUZones(new int[] { 13 })]
        [PrefixRegex("^P[P-Y]0F[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FernandodeNoronha = 56,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 36 })]
        [Deleted(true)]
        [ITUZones(new int[] { 47, 52 })]
        [PrefixRegex("^FQ8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        FrenchEquatorialAfrica = 57,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 26 })]
        [Deleted(true)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^FI8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        FrenchIndoChina = 58,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 35 })]
        [Deleted(true)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^FF[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        FrenchWestAfrica = 59,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("BS")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^C6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Bahamas = 60,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("RU")]
        [CQZones(new int[] { 40 })]
        [Deleted(false)]
        [ITUZones(new int[] { 75 })]
        [PrefixRegex("^R1/F[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FranzJosefLand = 61,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("BB")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^8P[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Barbados = 62,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("GF")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^FY[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FrenchGuiana = 63,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("BM")]
        [CQZones(new int[] { 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^VP9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Bermuda = 64,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("VG")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^VP2V[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BritishVirginIslands = 65,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("BZ")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^V3[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Belize = 66,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 22 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^FN8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        FrenchIndia = 67,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^(8Z5|9K3)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KuwaitSaudiArabiaNeutralZone = 68,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("KY")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^ZF[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CaymanIslands = 69,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CU")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^C[MO][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Cuba = 70,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("EC")]
        [CQZones(new int[] { 10 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^H[CD]8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        GalápagosIslands = 71,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("DO")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^HI[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        DominicanRepublic = 72,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("SV")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(YS|HU)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ElSalvador = 74,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("GE")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^4L[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Georgia = 75,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("GT")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^T[GD][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Guatemala = 76,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("GD")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^J3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Grenada = 77,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("HT")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^HH[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Haiti = 78,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("GP")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(FG|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Guadeloupe = 79,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("HN")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^H[QR][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Honduras = 80,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 14 })]
        [Deleted(true)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^DA-DM[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        WestGermany = 81,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("JM")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^6Y[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Jamaica = 82,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("MQ")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(FM|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Martinique = 84,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 9 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        BonaireandCuraçao = 85,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("NI")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(YN|H[67T])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Nicaragua = 86,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("PA")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^H[OP][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Panama = 88,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("TC")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^VP5[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        TurksandCaicosIslands = 89,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("TT")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^9[YZ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        TrinidadandTobago = 90,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("AW")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^P4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Aruba = 91,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 39 })]
        [Deleted(true)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("")]
        [OutgoingQSLService(false)]
        GeyserReef = 93,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("AG")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^V2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AntiguaandBarbuda = 94,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("DM")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^J7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Dominica = 95,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("MS")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^VP2M[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Montserrat = 96,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("LC")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^J6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaintLucia = 97,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("VC")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^J8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SaintVincentandtheGrenadines = 98,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex(@"^(FT\/G|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        GloriosoIslands = 99,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("AR")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14, 16 })]
        [PrefixRegex("^L[O-W][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Argentina = 100,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 22 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^CR8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Goa = 101,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 35 })]
        [Deleted(true)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^ZD4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        BritishTogoland = 102,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("GU")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 64 })]
        [PrefixRegex("^KH2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Guam = 103,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BO")]
        [CQZones(new int[] { 10 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12, 14 })]
        [PrefixRegex("^CP[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Bolivia = 104,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KG4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        GuantanamoBay = 105,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GG")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[UP][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Guernsey = 106,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GN")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^3X[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Guinea = 107,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BR")]
        [CQZones(new int[] { 11 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12, 13, 15 })]
        [PrefixRegex("^(P[P-Y]|Z[V-Z])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Brazil = 108,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GW")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^J5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        GuineaBissau = 109,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH[67][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Hawaii = 110,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("HM")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 68 })]
        [PrefixRegex("^VK0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        HeardIslandandMcDonaldIslands = 111,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CL")]
        [CQZones(new int[] { 12 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14, 16 })]
        [PrefixRegex("^C[A-E][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Chile = 112,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 33 })]
        [Deleted(true)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^EA9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Ifni = 113,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("IM")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[DT][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        IsleofMan = 114,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 37 })]
        [Deleted(true)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^I5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        ItalianSomaliland = 115,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CO")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^(H[JK]|5[JK])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Colombia = 116,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("UN")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^4U[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        InternationalTelecommunicationUnionHeadquarters = 117,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SJ")]
        [CQZones(new int[] { 40 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^JX[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        JanMayen = 118,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^PK[1-3][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Java = 119,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("EC")]
        [CQZones(new int[] { 10 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^H[CD][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Ecuador = 120,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("JE")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[JH][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Jersey = 122,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        JohnstonAtoll = 123,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex(@"^(FT\/J|E|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        JuandeNovaandEuropaIslands = 124,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CL")]
        [CQZones(new int[] { 12 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14 })]
        [PrefixRegex("^CE0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        JuanFernándezIslands = 125,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("RU")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^[UR]A2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Kaliningrad = 126,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^VS9K[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KamaranIsland = 127,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 16 })]
        [Deleted(true)]
        [ITUZones(new int[] { 19 })]
        [PrefixRegex("^UN1[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KareloFinnishSovietSocialistRepublic = 128,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("GY")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^8R[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Guyana = 129,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KZ")]
        [CQZones(new int[] { 17 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29, 30, 31 })]
        [PrefixRegex("^U[N-Q][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Kazakhstan = 130,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 68 })]
        [PrefixRegex(@"^FT\/X[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        KerguelenIslands = 131,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("PY")]
        [CQZones(new int[] { 11 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14 })]
        [PrefixRegex("^ZP[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Paraguay = 132,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NZ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^ZL8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        KermadecIslands = 133,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 31 })]
        [Deleted(true)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH5K[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KingmanReef = 134,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KG")]
        [CQZones(new int[] { 17 })]
        [Deleted(false)]
        [ITUZones(new int[] { 30, 31 })]
        [PrefixRegex("^EX[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Kyrgyzstan = 135,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("PE")]
        [CQZones(new int[] { 10 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^O[A-C][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Peru = 136,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KR")]
        [CQZones(new int[] { 25 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^(HL|6[K-N])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthKorea = 137,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH7K[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KureAtoll = 138,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^VS9H[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        KhuriyaMuriyaIslands = 139,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("SR")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^PZ[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Suriname = 140,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("FK")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 16 })]
        [PrefixRegex("^VP8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FalklandIslands = 141,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IN")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^VU7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Lakshadweep = 142,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("LA")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^XW[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Laos = 143,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("UY")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14 })]
        [PrefixRegex("^C[V-X][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Uruguay = 144,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("LV")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^YL[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Latvia = 145,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("LT")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^LY[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Lithuania = 146,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^VK9L[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        LordHoweIsland = 147,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("VE")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^(Y[V-Y]|4M)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Venezuela = 148,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("PT")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 36 })]
        [PrefixRegex("^CU[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Azores = 149,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 29, 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 55, 58, 59 })]
        [PrefixRegex("^(VK|AX)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Australia = 150,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 16 })]
        [Deleted(true)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^R1/M[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        MalyVysotskyIsland = 151,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("MO")]
        [CQZones(new int[] { 24 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^XX9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Macao = 152,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^VK0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MacquarieIsland = 153,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^4W[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        YemenArabRepublic = 154,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^(VS|9M)2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Malaya = 155,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NR")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^C2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Nauru = 157,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("VU")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^YJ[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Vanuatu = 158,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("MV")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^8Q[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Maldives = 159,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("TO")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^A3[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Tonga = 160,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CO")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 12 })]
        [PrefixRegex("^HK0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MalpeloIsland = 161,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NC")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^(FK|TX)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NewCaledonia = 162,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PG")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^P2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PapuaNewGuinea = 163,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 24 })]
        [Deleted(true)]
        [ITUZones(new int[] { 33 })]
        [PrefixRegex("^C9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Manchuria = 164,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MU")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^3B8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Mauritius = 165,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("MP")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 64 })]
        [PrefixRegex("^KH0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        MarianaIslands = 166,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^OJ0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MärketIsland = 167,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("MH")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^V7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MarshallIslands = 168,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("YT")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^(FH|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Mayotte = 169,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NZ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^Z[L-M][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NewZealand = 170,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^VK9M[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MellishReef = 171,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PN")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^VP6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        PitcairnIslands = 172,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("FM")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^V6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Micronesia = 173,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61 })]
        [PrefixRegex("^KH4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        MidwayAtoll = 174,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PF")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^(FO|TX)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FrenchPolynesia = 175,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("FJ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^3D2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Fiji = 176,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("JP")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 90 })]
        [PrefixRegex("^JD1[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MinamiTorishima = 177,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 32 })]
        [Deleted(true)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^1M[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        MinervaReefs = 178,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("MD")]
        [CQZones(new int[] { 16 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^ER[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Moldova = 179,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GR")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^SV/A[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MountAthos = 180,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MZ")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^C[89][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Mozambique = 181,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KP1[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        NavassaIsland = 182,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^PK5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        NetherlandsBorneo = 183,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^JZ0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        NetherlandsNewGuinea = 184,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("SB")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^H4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SolomonIslands = 185,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 2, 5 })]
        [Deleted(true)]
        [ITUZones(new int[] { 9 })]
        [PrefixRegex("^VO[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Newfoundland, Labrador = 186,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("NE")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^5U[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Niger = 187,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NU")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^E6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Niue = 188,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 60 })]
        [PrefixRegex("^VK9N[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NorfolkIsland = 189,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("WS")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^5W[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Samoa = 190,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("CK")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^E5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        NorthCookIslands = 191,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("JP")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 45 })]
        [PrefixRegex("^JD1[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        OgasawaraIslands = 192,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 25 })]
        [Deleted(true)]
        [ITUZones(new int[] { 45 })]
        [PrefixRegex("^(KR[68]|JR6|KA6)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        RyukyuIslands = 193,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 27 })]
        [Deleted(true)]
        [ITUZones(new int[] { 45 })]
        [PrefixRegex("^7J1[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Okinotorishima = 194,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GQ")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^3C0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Annobón = 195,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 61, 62 })]
        [PrefixRegex("^KH5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PalmyraandJarvisIslands = 197,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^(P2|VK9)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PapuaTerritory = 198,

        [EnumMember]
        [ContinentName("AN")]
        [ISOCountryCode("BV")]
        [CQZones(new int[] { 12 })]
        [Deleted(false)]
        [ITUZones(new int[] { 72 })]
        [PrefixRegex("^3Y[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        PeterIIsland = 199,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^CR(8|10)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PortugueseTimor = 200,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZA")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^ZS8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        PrinceEdwardandMarionIslands = 201,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("PR")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KP[34][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        PuertoRico = 202,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("AD")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^C3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Andorra = 203,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("MX")]
        [CQZones(new int[] { 6 })]
        [Deleted(false)]
        [ITUZones(new int[] { 10 })]
        [PrefixRegex("^X[A-I]4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        RevillagigedoIslands = 204,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SH")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 66 })]
        [PrefixRegex("^ZD8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AscensionIsland = 205,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("AT")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^OE[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Austria = 206,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MU")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^3B9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        RodriguesIsland = 207,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 36 })]
        [Deleted(true)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^9U5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        RuandaUrundi = 208,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("BE")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^O[N-T][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Belgium = 209,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 14 })]
        [Deleted(true)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^9S4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Saar = 210,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CA")]
        [CQZones(new int[] { 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 9 })]
        [PrefixRegex("^CY0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SableIsland = 211,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("BG")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^LZ[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Bulgaria = 212,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("FR")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(FS|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaintMartin = 213,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("FR")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^TK[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Corsica = 214,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("CY")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^(5B|C4|P3)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Cyprus = 215,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CO")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^HK0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SanAndrésandProvidencia = 216,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CL")]
        [CQZones(new int[] { 12 })]
        [Deleted(false)]
        [ITUZones(new int[] { 14 })]
        [PrefixRegex("^CE0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        DesventuradasIslands = 217,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 15 })]
        [Deleted(true)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^O[K-M][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Czechoslovakia = 218,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ST")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47 })]
        [PrefixRegex("^S9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SaoTomeandPrincipe = 219,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^VS4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Sarawak = 220,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("DK")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^O[U-WZ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Denmark = 221,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("FO")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^OY[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        FaroeIslands = 222,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^(G|GX|M)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        England = 223,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("FI")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^O[F-I][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Finland = 224,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("IT")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^I[SM]0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Sardinia = 225,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^8Z4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SaudiArabiaIraqNeutralZone = 226,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("FR")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^F[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        France = 227,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 7 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(HK0|KP3|KS4)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SerranaBankRoncadorCay = 228,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 14 })]
        [Deleted(true)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^(DM|Y[2-9])[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        EastGermany = 229,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("DE")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^D[A-R][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Germany = 230,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 22 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^AC3[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Sikkim = 231,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SO")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^(T5|6O)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Somalia = 232,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GI")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^ZB2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Gibraltar = 233,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("CK")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^E5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SouthCookIslands = 234,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 73 })]
        [PrefixRegex("^(VP8|LU)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthGeorgiaIsland = 235,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GR")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^(S[V-Z]|J4)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Greece = 236,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("GL")]
        [CQZones(new int[] { 40 })]
        [Deleted(false)]
        [ITUZones(new int[] { 5, 75 })]
        [PrefixRegex("^OX[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Greenland = 237,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("AQ")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 73 })]
        [PrefixRegex("^(VP8|LU)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthOrkneyIslands = 238,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("HU")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^H[AG][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Hungary = 239,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 73 })]
        [PrefixRegex("^(VP8|LU)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthSandwichIslands = 240,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("AQ")]
        [CQZones(new int[] { 13 })]
        [Deleted(false)]
        [ITUZones(new int[] { 73 })]
        [PrefixRegex("^(VP8|LU|CE9|HF0|4K1)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthShetlandIslands = 241,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("IS")]
        [CQZones(new int[] { 40 })]
        [Deleted(false)]
        [ITUZones(new int[] { 17 })]
        [PrefixRegex("^TF[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Iceland = 242,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 21 })]
        [Deleted(true)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^VS9[APS][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PeoplesDemocraticRepofYemen = 243,

[EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 34 })]
        [Deleted(true)]
        [ITUZones(new int[] { 47, 48 })]
        [PrefixRegex("^ST0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SouthernSudan = 244,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("IE")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^E[IJ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Ireland = 245,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^1A[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SovereignMilitaryOrderofMalta = 246,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 50 })]
        [PrefixRegex("")]
        [OutgoingQSLService(false)]
        SpratlyIslands = 247,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("IT")]
        [CQZones(new int[] { 15, 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^I[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Italy = 248,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("KN")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^V4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SaintKittsandNevis = 249,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SH")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 66 })]
        [PrefixRegex("^ZD7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        StHelena = 250,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("LI")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^HB0[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Liechtenstein = 251,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CA")]
        [CQZones(new int[] { 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 9 })]
        [PrefixRegex("^CY9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        StPaulIsland = 252,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BR")]
        [CQZones(new int[] { 11 })]
        [Deleted(false)]
        [ITUZones(new int[] { 13 })]
        [PrefixRegex("^P[P-Y]0S[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaintPeterandSaintPaulArchipelago = 253,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("LU")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^LX[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Luxembourg = 254,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 8 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        StMaartenSabaStEustatius = 255,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("PT")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 36 })]
        [PrefixRegex("^CT3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Madeira = 256,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("MT")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^9H[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Malta = 257,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^PK4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Sumatra = 258,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SJ")]
        [CQZones(new int[] { 40 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^JW[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Svalbard = 259,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("MC")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^3A[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Monaco = 260,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 7 })]
        [Deleted(true)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KS4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SwanIs = 261,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("TJ")]
        [CQZones(new int[] { 17 })]
        [Deleted(false)]
        [ITUZones(new int[] { 30 })]
        [PrefixRegex("^EY[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Tajikistan = 262,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("NL")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^P[A-I][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Netherlands = 263,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 33 })]
        [Deleted(true)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^CN2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Tangier = 264,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("XI")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[IN][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NorthernIreland = 265,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("NO")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^L[A-N][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Norway = 266,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 28 })]
        [Deleted(true)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^(P2|VK9)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        TerritoryofNewGuinea = 267,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 23 })]
        [Deleted(true)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^AC4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Tibet = 268,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("PL")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^S[N-R][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Poland = 269,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("TK")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^ZK3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Tokelau = 270,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 15 })]
        [Deleted(true)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^I1[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Trieste = 271,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("PT")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^CT[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Portugal = 272,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BR")]
        [CQZones(new int[] { 11 })]
        [Deleted(false)]
        [ITUZones(new int[] { 15 })]
        [PrefixRegex("^P[P-Y]0T[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        TrindadeandMartinVaz = 273,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SH")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 66 })]
        [PrefixRegex("^ZD9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        TristandaCunhaandGoughIslands = 274,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("RO")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^Y[O-R][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Romania = 275,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TF")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex(@"^(FT\/T|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        TromelinIsland = 276,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("PM")]
        [CQZones(new int[] { 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 9 })]
        [PrefixRegex("^FP[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaintPierreandMiquelon = 277,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SM")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^T7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SanMarino = 278,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[MS][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Scotland = 279,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("TM")]
        [CQZones(new int[] { 17 })]
        [Deleted(false)]
        [ITUZones(new int[] { 30 })]
        [PrefixRegex("^EZ[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Turkmenistan = 280,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ES")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^E[A-H][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Spain = 281,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("TV")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^T2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Tuvalu = 282,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^ZC4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SovereignBaseAreasofAkrotiriandDhekelia = 283,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SE")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 18 })]
        [PrefixRegex("^(S[A-M]|[78]S)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Sweden = 284,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("VI")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^KP2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        USVirginIslands = 285,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("UG")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^5X[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Uganda = 286,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("CH")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^HB[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Switzerland = 287,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("UA")]
        [CQZones(new int[] { 16 })]
        [Deleted(false)]
        [ITUZones(new int[] { 29 })]
        [PrefixRegex("^(U[R-Z]|E[M-O])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Ukraine = 288,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("UN")]
        [CQZones(new int[] { 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 8 })]
        [PrefixRegex("^4U[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        UnitedNationsHeadquarters = 289,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 3, 4, 5 })]
        [Deleted(false)]
        [ITUZones(new int[] { 6, 7, 8 })]
        [PrefixRegex("^(K|W|N|A[A-K])[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        UnitedStatesofAmerica = 291,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("UZ")]
        [CQZones(new int[] { 17 })]
        [Deleted(false)]
        [ITUZones(new int[] { 30 })]
        [PrefixRegex("^U[J-M][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Uzbekistan = 292,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("VN")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^(3W|XV)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        VietNam = 293,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("GB")]
        [CQZones(new int[] { 14 })]
        [Deleted(false)]
        [ITUZones(new int[] { 27 })]
        [PrefixRegex("^G[WC][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Wales = 294,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("VA")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^HV[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Vatican = 295,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("RS")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^Y[TU][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Serbia = 296,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("US")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^KH9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        WakeIsland = 297,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("WF")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^FW[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        WallisandFutunaIslands = 298,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("MY")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^9M[24][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        WestMalaysia = 299,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("KI")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^T30[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        GilbertIslands = 301,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("EH")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^S0[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        WesternSahara = 302,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AU")]
        [CQZones(new int[] { 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 55 })]
        [PrefixRegex("^VK9W[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        WillisIsland = 303,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("BH")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^A9[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Bahrain = 304,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("BD")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^S2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Bangladesh = 305,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("BT")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^A5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Bhutan = 306,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 37 })]
        [Deleted(true)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^(VQ1|5H1)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Zanzibar = 307,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("CR")]
        [CQZones(new int[] { 7 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^T[IE][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CostaRica = 308,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("MM")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^X[YZ][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Myanmar = 309,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KH")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^XU[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Cambodia = 312,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("LK")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^4S[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SriLanka = 315,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("CN")]
        [CQZones(new int[] { 23, 24 })]
        [Deleted(false)]
        [ITUZones(new int[] { 33, 42, 43, 44 })]
        [PrefixRegex("^B[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        China = 318,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("HK")]
        [CQZones(new int[] { 24 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^VR[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        HongKong = 321,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IN")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^VU[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        India = 324,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("ID")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 51, 54 })]
        [PrefixRegex("^Y[B-H][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Indonesia = 327,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IR")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 40 })]
        [PrefixRegex("^E[PQ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Iran = 330,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IQ")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^YI[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Iraq = 333,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("IL")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^4[XZ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Israel = 336,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("JP")]
        [CQZones(new int[] { 25 })]
        [Deleted(false)]
        [ITUZones(new int[] { 45 })]
        [PrefixRegex("^(J[A-S]|7[J-N])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Japan = 339,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("JO")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^JY[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Jordan = 342,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KP")]
        [CQZones(new int[] { 25 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^P5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        DemocraticPeoplesrepublicOfKorea = 344,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("BN")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^V8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BruneiDarussalam = 345,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("KW")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^9K[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Kuwait = 348,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("LB")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^OD[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Lebanon = 354,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("MN")]
        [CQZones(new int[] { 23 })]
        [Deleted(false)]
        [ITUZones(new int[] { 32, 33 })]
        [PrefixRegex("^J[T-V][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Mongolia = 363,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("NP")]
        [CQZones(new int[] { 22 })]
        [Deleted(false)]
        [ITUZones(new int[] { 42 })]
        [PrefixRegex("^9N[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Nepal = 369,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("OM")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^A4[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Oman = 370,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("PK")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 41 })]
        [PrefixRegex("^AP[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Pakistan = 372,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PH")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 50 })]
        [PrefixRegex("^(D[U-Z]|4[D-I])[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Philippines = 375,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("QA")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^A7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Qatar = 376,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("SA")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^HZ[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaudiArabia = 378,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SC")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^S7[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Seychelles = 379,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("SG")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^9V[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Singapore = 381,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("DJ")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^J2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Djibouti = 382,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("SY")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^YK[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Syria = 384,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("TW")]
        [CQZones(new int[] { 24 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^B[U-X][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Taiwan = 386,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("TH")]
        [CQZones(new int[] { 26 })]
        [Deleted(false)]
        [ITUZones(new int[] { 49 })]
        [PrefixRegex("^(HS|E2)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Thailand = 387,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("TR")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^T[A-C][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Turkey = 390,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("AE")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^A6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        UnitedArabEmirates = 391,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("DZ")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^7[T-Y][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Algeria = 400,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("AO")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^D[23][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Angola = 401,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("BW")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^A2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Botswana = 402,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("BI")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^9U[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Burundi = 404,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CM")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47 })]
        [PrefixRegex("^TJ[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Cameroon = 406,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CF")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47 })]
        [PrefixRegex("^TL[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        CentralAfricanRepublic = 408,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CV")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^D4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        CapeVerde = 409,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TD")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47 })]
        [PrefixRegex("^TT[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Chad = 410,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("KM")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^D6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Comoros = 411,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CG")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^TN[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        RepublicoftheCongo = 412,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CD")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^9[Q-T][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        DemocraticRepublicoftheCongo = 414,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("BJ")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^TY[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Benin = 416,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GA")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^TR[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Gabon = 420,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GM")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^C5[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        TheGambia = 422,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("GH")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^9G[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Ghana = 424,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("CI")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^TU[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        CotedIvoire = 428,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("KE")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^5[YZ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Kenya = 430,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("LS")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^7P[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Lesotho = 432,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("LR")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^EL[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Liberia = 434,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("LY")]
        [CQZones(new int[] { 34 })]
        [Deleted(false)]
        [ITUZones(new int[] { 38 })]
        [PrefixRegex("^5A[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Libya = 436,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MG")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^5R[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Madagascar = 438,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MW")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^7Q[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Malawi = 440,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ML")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^TZ[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Mali = 442,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MR")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^5T[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Mauritania = 444,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("MA")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^CN[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Morocco = 446,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("NG")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^5N[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Nigeria = 450,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZW")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^Z2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Zimbabwe = 452,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("FR")]
        [CQZones(new int[] { 39 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^(FR|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Réunion = 453,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("RW")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 52 })]
        [PrefixRegex("^9X[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Rwanda = 454,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SN")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^6[VW][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Senegal = 456,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SL")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^9L[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SierraLeone = 458,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("FJ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^3D2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        RotumaIsland = 460,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZA")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^Z[R-U][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SouthAfrica = 462,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("NA")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^V5[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Namibia = 464,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SD")]
        [CQZones(new int[] { 34 })]
        [Deleted(false)]
        [ITUZones(new int[] { 47, 48 })]
        [PrefixRegex("^ST[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Sudan = 466,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SZ")]
        [CQZones(new int[] { 38 })]
        [Deleted(false)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^3DA[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Eswatini = 468,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TZ")]
        [CQZones(new int[] { 37 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^5[HI][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Tanzania = 470,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TN")]
        [CQZones(new int[] { 33 })]
        [Deleted(false)]
        [ITUZones(new int[] { 37 })]
        [PrefixRegex("^3V[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Tunisia = 474,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("EG")]
        [CQZones(new int[] { 34 })]
        [Deleted(false)]
        [ITUZones(new int[] { 38 })]
        [PrefixRegex("^SU[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Egypt = 478,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("BF")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^XT[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BurkinaFaso = 480,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZM")]
        [CQZones(new int[] { 36 })]
        [Deleted(false)]
        [ITUZones(new int[] { 53 })]
        [PrefixRegex("^9[IJ][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Zambia = 482,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("TG")]
        [CQZones(new int[] { 35 })]
        [Deleted(false)]
        [ITUZones(new int[] { 46 })]
        [PrefixRegex("^5V[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Togo = 483,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 38 })]
        [Deleted(true)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^ZS9[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        WalvisBay = 488,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("FJ")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^3D2[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        ConwayReef = 489,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("KI")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 65 })]
        [PrefixRegex("^T33[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Banaba = 490,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("YE")]
        [CQZones(new int[] { 21 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^7O[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Yemen = 492,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("ZZ")]
        [CQZones(new int[] { 38 })]
        [Deleted(true)]
        [ITUZones(new int[] { 57 })]
        [PrefixRegex("^ZS[01][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PenguinIs = 493,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("HR")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^9A[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Croatia = 497,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SI")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^S5[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Slovenia = 499,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("BA")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^E7[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        BosniaHerzegovina = 501,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("MK")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^Z3[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        NorthMacedonia = 502,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("CZ")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^O[KL][A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        CzechRepublic = 503,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("SK")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^OM[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Slovakia = 504,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("TW")]
        [CQZones(new int[] { 24 })]
        [Deleted(false)]
        [ITUZones(new int[] { 44 })]
        [PrefixRegex("^BV9P[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        PratasIsland = 505,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("CN")]
        [CQZones(new int[] { 27 })]
        [Deleted(false)]
        [ITUZones(new int[] { 50 })]
        [PrefixRegex("^BS7[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        ScarboroughShoal = 506,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("SB")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 51 })]
        [PrefixRegex("^H40[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        TemotuProvince = 507,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PF")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^(FO|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        AustralIslands = 508,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PF")]
        [CQZones(new int[] { 31 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^(FO|TX)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        MarquesasIslands = 509,

        [EnumMember]
        [ContinentName("AS")]
        [ISOCountryCode("PS")]
        [CQZones(new int[] { 20 })]
        [Deleted(false)]
        [ITUZones(new int[] { 39 })]
        [PrefixRegex("^E4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Palestine = 510,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("TL")]
        [CQZones(new int[] { 28 })]
        [Deleted(false)]
        [ITUZones(new int[] { 54 })]
        [PrefixRegex("^4W[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        TimorLeste = 511,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("NC")]
        [CQZones(new int[] { 30 })]
        [Deleted(false)]
        [ITUZones(new int[] { 56 })]
        [PrefixRegex("^(FK|TX)[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        ChesterfieldIslands = 512,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("PN")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 63 })]
        [PrefixRegex("^VP6[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        DucieIsland = 513,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("ME")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^4O[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        Montenegro = 514,

        [EnumMember]
        [ContinentName("OC")]
        [ISOCountryCode("AS")]
        [CQZones(new int[] { 32 })]
        [Deleted(false)]
        [ITUZones(new int[] { 62 })]
        [PrefixRegex("^KH8[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SwainsIsland = 515,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("FR")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^(FJ|TO)[A-Z0-9/]*$")]
        [OutgoingQSLService(true)]
        SaintBarthélemy = 516,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("CW")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ2[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Curaçao = 517,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("SX")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ7[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SintMaarten = 518,

        [EnumMember]
        [ContinentName("NA")]
        [ISOCountryCode("BQ")]
        [CQZones(new int[] { 8 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ[56][A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SabaandSintEustatius = 519,

        [EnumMember]
        [ContinentName("SA")]
        [ISOCountryCode("BQ")]
        [CQZones(new int[] { 9 })]
        [Deleted(false)]
        [ITUZones(new int[] { 11 })]
        [PrefixRegex("^PJ4[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Bonaire = 520,

        [EnumMember]
        [ContinentName("AF")]
        [ISOCountryCode("SS")]
        [CQZones(new int[] { 34 })]
        [Deleted(false)]
        [ITUZones(new int[] { 48 })]
        [PrefixRegex("^Z8[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        SouthSudan = 521,

        [EnumMember]
        [ContinentName("EU")]
        [ISOCountryCode("XK")]
        [CQZones(new int[] { 15 })]
        [Deleted(false)]
        [ITUZones(new int[] { 28 })]
        [PrefixRegex("^Z6[A-Z0-9/]*$")]
        [OutgoingQSLService(false)]
        Kosovo = 522
    }

    public class ContinentNameAttribute : Attribute
    {
        public string ContinentName;
        public ContinentNameAttribute(string continentName) { ContinentName = continentName; }
    }

    public class ISOCountryCodeAttribute : Attribute
    {
        public string ISOCountryCode;
        public ISOCountryCodeAttribute(string countryCode) { ISOCountryCode = countryCode; }
    }

    public class CQZonesAttribute : Attribute
    {
        public List<int> CQZones = new List<int>();
        public CQZonesAttribute(int[] cQZones)
        {
            foreach(int cQZone in cQZones)
            {
                CQZones.Add(cQZone);
            }
        }
    }

    public class DeletedAttribute : Attribute
    {
        public bool Deleted;
        public DeletedAttribute(bool deleted) { Deleted = deleted; }
    }

    public class ITUZonesAttribute : Attribute
    {
        public List<int> ITUZones = new List<int>();
        public ITUZonesAttribute(int[] zoneList)
        {
            foreach (int zone in zoneList)
            {
                ITUZones.Add(zone);
            }
        }
    }

    public class PrefixRegexAttribute : Attribute
    {
        public string PrefixRegex = string.Empty;
        public PrefixRegexAttribute(string prefixRegex) { PrefixRegex = prefixRegex; }
    }

    public class OutgoingQSLServiceAttribute : Attribute
    {
        public bool OutgoingQSLService;
        public OutgoingQSLServiceAttribute(bool outgoingQSLService) { OutgoingQSLService = outgoingQSLService; }
    }

}