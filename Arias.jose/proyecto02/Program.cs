using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyecto02
{
    class ejercicio02
    {
        static void Main(string[] args)
        {
            double valor;
            double cubo;
            double cuadrado;
            bool flag = true;
            
            Console.Title = "Ejercicio02";
            while(flag)
            {
                Console.WriteLine("Ingrese un valor: ");
                valor = double.Parse(Console.ReadLine());
                if(valor <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.ReadKey();
                }
                else
                {
                    cuadrado = Math.Pow(valor,2) ;
                    cubo = Math.Pow(valor,3);
                    Console.WriteLine("Cuadrado:{0}\nCubo:{1}", cuadrado, cubo);
                    break;
                }
                Console.Clear();
            }
            
        }
    }
}
