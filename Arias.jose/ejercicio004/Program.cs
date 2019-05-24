using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1; // numero a evaluar
            int s; // suma de divisores propios
            int d; // divisor inicia en 1
            int contador = 0; //contador de numeros perfectos 
            Console.Title = "Ejercicio04";

            while (n > 0 && contador <= 4)
            {
                d = 1;
                s = 0;
                while (d <= n / 2)
                {
                    if (n % d == 0)
                    {
                        s += d;
                    }
                    d++;
                }

                if (s == n)
                {

                    Console.WriteLine(n.ToString("#,###.00"));
                    contador++;
                }
                n++;
            }
            Console.ReadKey();
        }
    }
}
