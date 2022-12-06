using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop3
{
    internal class RiempiLitriException : Exception
    {
       
            public RiempiLitriException() : base()
            {

            }
            public RiempiLitriException(string message) : base(message)
            {

           }
        
    }
}
