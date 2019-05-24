using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            string paramOpcional = "Feliz dia";
            // Instanciacion de la clase
            var obj = new Metodos();
            // Imprime siempre el dia de hoy
            obj.printDate();
            Console.ReadLine();
            // Imprime el dia ingresado
            obj.printDate(new DateTime(1991,09,18));
            Console.ReadLine();
            //Imprime la fecha a partir de un string
            obj.printDate("07/08/1956");
            Console.ReadLine();
            //Impime la fecha y un comentario de la misma
            //obj.printDate(new DateTime(1918,03,27),"Este es el comentario");
            //Console.ReadLine();
            //Imprime la fecha y un comentario, tiene mismos parametro diferente orden de estos lo diferencia la firma
            obj.printDate("Este es una firma distinta", new DateTime(2018, 11, 04));
            Console.ReadLine();
            //PARAMETROS OPCIONALES
            Console.WriteLine("Parametros opcionales");
            // Sin parametro
            obj.printDate(new DateTime(2019,03,20));
            Console.ReadLine();
            // Con parametro
            obj.printDate(new DateTime(2019, 04, 21), paramOpcional);
        }
    }
}
