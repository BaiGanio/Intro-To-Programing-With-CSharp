using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp.Common.Enums
{
    public enum GenderWithChangedUnderlayingDataTypeAndValues : short
    {
        Unknown = 69,
        Male = 15,
        /* This will lead to compile time error */
        //Male = 15897867896,
        Female = 23
    }
}
