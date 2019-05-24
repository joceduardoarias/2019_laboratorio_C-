using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
   public class Conversor
    {
        public static string DecimalBinario(double valor)
        {
            string retorno = "";
            int divisor = 2;
            while(divisor <= valor)
            {
                retorno += valor % divisor;  
            }
            return retorno;
        }
    }
}
