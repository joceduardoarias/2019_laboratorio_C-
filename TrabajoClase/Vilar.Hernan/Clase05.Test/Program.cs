using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;



namespace Clase05.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta ob1 = new Tinta();
            Tinta ob2 = new Tinta(ConsoleColor.Blue,ETipoTinta.China);
            Tinta ob3 = new Tinta(ConsoleColor.Yellow, ETipoTinta.China);
            Tinta ob4 = new Tinta();
            Pluma pluma1 = new Pluma("bic",ob1,20);
            string dato;

            pluma1 = pluma1 + ob2;
            dato = pluma1;
            // el equals es usa asi el objeto y adentro con lo que vas a comprar ese objeto
            /*if(ob1!=ob4)
            {
                Console.WriteLine("Son distintos");
            }
            else
            {
                Console.WriteLine("son iguales");
            }
            */
            Console.WriteLine(dato);
            
            Console.ReadKey();
        }
    }
}
