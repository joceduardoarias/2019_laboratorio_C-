using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            int limMin = 0;
            int limMax = 0;
            int valor;
            
            float promedio;
            Console.WriteLine("ingrese rango minimo: ");
            limMin = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese rango maximo: ");
            limMax = int.Parse(Console.ReadLine());
            
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero entre -100 y 100");
                valor = int.Parse(Console.ReadLine());
                if (!Validacion.Validar(limMin, limMax, valor))
                {
                    Console.WriteLine(" Erro!! el numero debe estar entre {0} y {1}",limMin,limMax);
                    break;
                }
                else
                {   if(i==0)
                    {
                        min = valor;
                        max = valor;
                    }
                    
                    if (valor < min)
                    {
                        min = valor;
                    }
                    if (valor > max)
                    {
                        max = valor;
                    }
                    acumulador += valor;
                }
            }
            promedio = (float)(acumulador / i);
            Console.WriteLine("minimo: {0}\n maximo: {1}\n promedio: {2}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
