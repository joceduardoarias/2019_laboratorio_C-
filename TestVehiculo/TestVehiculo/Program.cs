using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase09;
namespace TestVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero l1 = new Lavadero(30, 50, 20);
            Auto auto1 = new Auto("AAA123", 4, Emarcas.Ferrari, 5);
            Camion camion1 = new Camion("BBB321",Emarcas.Renault,18,16);
            Moto moto1 = new Moto("MNB258", 2, Emarcas.Zanella, 225);

            l1 = l1 + auto1;
            l1 = l1 + camion1;
            l1 = l1 + moto1;

            // Console.WriteLine(auto1.MostrarAuto());
            Console.WriteLine(l1.MyLavadero);
            Console.ReadKey();
        }
    }
}
