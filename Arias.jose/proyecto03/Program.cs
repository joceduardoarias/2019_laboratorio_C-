using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto03
{
    class ejercicio03
    {
        static void Main(string[] args)
        {
            int numero, i;
            int contador;
            int j=1;
            Console.WriteLine("ingrese numero: ");
            numero = int.Parse(Console.ReadLine());


            for (i = 1; i <= numero; i++)
            {
                contador = 0;
                for(j=1;j<=i;j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("{0}", numero);
                }              
                
            }



        }

    }
}
