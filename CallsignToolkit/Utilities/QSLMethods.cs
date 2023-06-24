using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallsignToolkit.Utilities
{
    public class QSLMethods
    {
        public string QSLManager { get { return qslManager ?? string.Empty; } set { qslManager = value; } }
        public bool UseEQSL { get { return useEQSL ?? false; } set { useEQSL = value; } }
        public bool UseLOTW { get { return useLOTW ?? false; } set { useLOTW = value; } }
        public bool UsePaperQSL { get { return usePaperQSL ?? false; } set { usePaperQSL = value; } }

        private string? qslManager;
        private bool? useEQSL;
        private bool? useLOTW;
        private bool? usePaperQSL;
    }
}
