using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using boli;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            Boligrafo b1 = new Boligrafo(ConsoleColor.Blue,5);
            b1.Pintar(-3, out dato);
            Console.WriteLine(dato);
            Boligrafo b2 = new Boligrafo(ConsoleColor.Cyan, 50);
            b2.Pintar(-4, out dato);
            Console.WriteLine(dato);
            

            //Test.Saludar());
            Console.ReadKey();
        }
    }
}
