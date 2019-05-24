using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte; 
namespace TestVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo un lavadero
            Lavadero lavaderoUno = new Lavadero(40, 60, 30);
            Auto auto1 = new Auto("123AAA", 4, Emarcas.Ferrari, 4);
            Auto auto2 = new Auto("124BBB", 4, Emarcas.Renault, 4);
            Console.WriteLine(auto1.MostrarAuto());
            Console.WriteLine(auto2.MostrarAuto());
            lavaderoUno = lavaderoUno + auto1;
            //lavaderoUno = lavaderoUno + auto2;

            Console.WriteLine(lavaderoUno.MyLavadero);
        }
    }
}
