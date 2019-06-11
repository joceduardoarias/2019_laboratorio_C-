using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            Persona persona = new Persona(0,"juana", "Arias", 45);
            AccesoDatos datos = new AccesoDatos();
            lista = datos.TraerTodos();
            datos.AgregarPersona(persona);
            foreach (Persona item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            //uso del metodo agregar persona
           
            Console.ReadKey();
        }
    }
}
