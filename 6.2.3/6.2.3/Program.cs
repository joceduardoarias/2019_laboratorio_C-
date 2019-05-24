using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            libro myObj = new libro();
            Console.WriteLine("Autor: ");
            myObj.Autor = Console.ReadLine();
            Console.WriteLine("Titulo: ");
            myObj.Titulo = Console.ReadLine();
            Console.WriteLine("Ubicacion: ");
            myObj.Ubicacion = Console.ReadLine();
            Console.WriteLine("Autor: {0}\nTitulo: {1} \n Ubicacion: {2}", myObj.Autor, myObj.Titulo, myObj.Ubicacion);
        }
    }
}
