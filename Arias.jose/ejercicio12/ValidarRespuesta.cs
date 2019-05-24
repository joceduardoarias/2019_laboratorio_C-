using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(Char c)
        {
            bool retorno = false;
            if(c == 's' || c == 'S')
            {
                retorno = true;
            }

           return retorno; 
        }
    }
}
