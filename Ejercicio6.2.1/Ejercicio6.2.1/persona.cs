using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._2._1
{
    class persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value;}
        }

        public persona()
        {
            
        }

        public void Saludar(string name)
        {
            Console.WriteLine("Hola, soy {0}", name);
        }
    }
    class Juego
    {
        public void Lanzar()
        {
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para salir");
            Console.ReadKey();
        }
    }

}
