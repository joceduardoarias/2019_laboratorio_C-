﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mi central 
            Centralita c = new Centralita("Fede Center");
            //Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Moron","Bernal",21,Efranja.Franja_1);
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Efranja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita. 
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += (l1);
                Console.WriteLine(c.ToString());
                c += (l1);
                Console.WriteLine(c.ToString());
                c += (l2);
                Console.WriteLine(c.ToString());
                c += (l3);
                Console.WriteLine(c.ToString());
                c += (l4);
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaException e)
            {
                Console.WriteLine(e.NombreMetodo+e.NombreClase+e.Message);
                
            }
           
            Console.ReadKey();
        }
    }
}
