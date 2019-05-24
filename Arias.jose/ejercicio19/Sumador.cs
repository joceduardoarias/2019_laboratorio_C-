using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    public class Sumador
    {
        private int cantidadSumas;
        //CONSTRUCTORES
        public Sumador()
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int value) : this()
        {
            this.cantidadSumas = value;
        }
        //METODOS SUMADORES
        public long Sumar(long a, long b)
        {
            long retorno;
            retorno = a + b;
            this.cantidadSumas += 1;
            return retorno;
        }
        public string Sumar(string cadena1, string cadena2)
        {
            string retorno;
            retorno = cadena1 + cadena2;
            this.cantidadSumas += 1;
            return retorno;
        }
        // METODOS VONVERSORES
        public static explicit operator int(Sumador s)
        {
            int retorno = 0;
            retorno = s.cantidadSumas;
            return retorno;
        }
        public static bool operator | (Sumador s1, Sumador s2)
         {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
        public static long operator +(Sumador s1,Sumador s2)
        {
            long retorno = 0;
            retorno = (int)(s1.cantidadSumas + s2.cantidadSumas);
            return retorno;
        }

    }
}
