using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop3
{
    internal class CapacitàMassimaException : Exception
    {
        public CapacitàMassimaException() : base()
        {

        }
        public CapacitàMassimaException(string message) : base(message)
        {

        }
    }

}
