using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04;

namespace Clase04.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cosa ob1 = new Cosa(2,DateTime.Now,"jose");
           
            Console.WriteLine(ob1.Mostrar());
            Console.WriteLine(Cosa.Mostrar(ob1));
            Console.ReadKey();
           
        }
    }
}
