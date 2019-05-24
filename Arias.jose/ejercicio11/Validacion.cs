using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Validacion
    {
       

        public static bool Validar(int min, int max, int valor)
        {
            bool flag = false;                
            if(valor >= min && valor <= max)
            {
                flag = true;
                return flag;
            }
            else
            {
                return flag;
            }
            
        }
    }
}
