using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor estebanRey = new Autor("Esteban", "Rey");

            Manual economia = new Manual("Economia", 25.66f, "Domingo", "Caballo", ETipo.Finanzas);
            Novela miseria = new Novela("Miseria", 63.88f, estebanRey, EGenero.Romantica);
            Manual c = new Manual("C#", 29.95f, "Joe", "Mayo", ETipo.Tecnico);
            Novela miseria2 = new Novela("Miseria", 203f, estebanRey, EGenero.Accion);
            Novela miseria3 = new Novela("Miseria", 98f, estebanRey, EGenero.CienciaFiccion);

            Biblioteca miBiblioteca = 5;
            miBiblioteca += economia;
            miBiblioteca += miseria;
            miBiblioteca += c;
            miBiblioteca += miseria2;
            miBiblioteca += miseria3;

            Console.WriteLine("");
            Console.WriteLine(Biblioteca.Mostrar(miBiblioteca));

            Console.ReadKey();
        }
    }
}
