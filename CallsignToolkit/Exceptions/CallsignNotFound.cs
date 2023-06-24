﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallsignToolkit.Exceptions
{
    public class CallsignNotFound : Exception
    {
        public CallsignNotFound() { }
        public CallsignNotFound(string callsign) : base(string.Format("Provided call sign not found: {0}", callsign))
        {
        }
    }
}
