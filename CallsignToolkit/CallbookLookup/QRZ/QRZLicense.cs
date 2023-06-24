using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZLicense : License
    {
        public DateTime? GrantDate;
        public DateTime? ExpirationDate;
        public string ServiceCodes;
    }
}
