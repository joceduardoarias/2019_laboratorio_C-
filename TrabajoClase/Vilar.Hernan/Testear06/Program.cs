using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06;
namespace Testear06
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Black, "marca",5);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "maraca", 6);
            Tempera t3 = new Tempera(ConsoleColor.Blue, "asd", 6);
            t3 = null;
            if(null == t3)
            {
                Console.WriteLine("lal");
            }
            /*Paleta p1 = 10;
            Console.WriteLine((string)p1);
            */
            Console.ReadKey();

        }
    }
}
