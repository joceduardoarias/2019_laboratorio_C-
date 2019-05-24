using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "";
            Sello.color = ConsoleColor.Blue;

            //Console.WriteLine(Sello.Imprimir());
            //Sello.Borrar();
            //Console.WriteLine(Sello.Imprimir());
            Console.Write("Ingrese una palabra:");
            Sello.mensaje = Console.ReadLine();
            Sello.ImprimirEnColor();
            Console.ReadKey();
            

        }
    }
}
