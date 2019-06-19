using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajonLlenoExcepcion : Exception
    {
        public CajonLlenoExcepcion(string message)
            : base(message)
        { }
    }
}
