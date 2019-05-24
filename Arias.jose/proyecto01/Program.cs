using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto01
{
    class ejercicio01
    {
        static void Main(string[] args)
        {
            float acumaulador = 0;
            int valor;
            int i; int max = 0; int min = 0;
            float promedio;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese valor {0}:", i+1);
                valor = int.Parse(Console.ReadLine());
                acumaulador += valor;
                if (i == 0)
                {
                    max = valor;
                    min = valor;
                }
                if (min > valor)
                {
                    min = valor;
                }
                if (max < valor)
                {
                    max = valor;
                }
            }
            promedio =(float) acumaulador / i;
            Console.WriteLine("Promedio {0:#.###}\n Maximo: {1}\n Minimo: {2}", promedio, max, min);
        }
    }
}
