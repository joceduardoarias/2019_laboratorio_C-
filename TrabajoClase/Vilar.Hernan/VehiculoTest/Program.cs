using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace VehiculoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Auto unAuto = new Auto();
            Moto unaMoto = new Moto();
            Camion unCamion = new Camion();

            unCamion.patente = "camion";
            unCamion.marca = EMarca.Ferrari;
            unCamion.cantidadRuedas = 2;
            unCamion.tara = 3;

            unaMoto.patente = "moto";
            unaMoto.marca = EMarca.Ferrari;
            unaMoto.cantidadRuedas = 4;
            unaMoto.cilindrada = 3;

            unAuto.patente = "auto";
            unAuto.marca = EMarca.Scania;
            unAuto.cantidadRuedas = 2;
            unAuto.cantidadAsientos = 1;

            Console.WriteLine(unAuto.MostrarAuto());
            Console.WriteLine(unaMoto.MostrarMoto());
            Console.WriteLine(unCamion.MostrarCamion());
            Console.ReadKey();
            */
            Lavadero l1 = new Lavadero(20,30,10);
            Auto auto1 = new Auto("123A", 4, EMarca.Ferrari, 5);
            Moto moto1 = new Moto("124B", 2, EMarca.Honda, 225);
            Camion camion1 = new Camion("125C", 2, EMarca.Renault, 1500);

            l1 = l1 + auto1;
            l1 = l1 + camion1;
            l1 = l1 + moto1;
            //l1.MyLista.Add(moto1);
            //l1.MyLista.Add(camion1);
            Console.WriteLine(l1.MostrarTotalFacturado(Evehiculos.moto));
            Console.ReadKey();
        }
        
    }
}
