using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio19";
            int cantidaSumas1 = 0;
            int cantidaSumas2 = 0;
            long a =0;
            Sumador obj1;
            Sumador obj2;
            obj1 = new Sumador(10);
            obj2 = new Sumador();
            obj1.Sumar(1, 2);
            obj2.Sumar(3, 1);

            obj1.Sumar("hola", "mundo");
            obj2.Sumar("utn", "lab II");
            //COVERSION EXPLICITA INT
            cantidaSumas1 = (int)obj1;
            cantidaSumas2 = (int)obj1;
            //COVERSION IMPLICITA +
            a = (long)(obj1 + obj2);
            //CONVERSION IMPLICITA |
            if(obj1 | obj2)
            {
                Console.WriteLine("Cantidad de obj1: {0} \n Cantidad de obj2: {1} ", cantidaSumas1, cantidaSumas2);
            }
        }
    }
}
