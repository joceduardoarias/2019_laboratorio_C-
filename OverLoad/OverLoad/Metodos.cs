using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    public class Metodos
    {
        // Imprime siempre el dia de hoy
        public void printDate()
        {
            Console.WriteLine("The day is {0}", DateTime.Now);

        }
        // Imprime el dia ingresado
        public void printDate(DateTime fecha)
        {
            Console.WriteLine("The day is {0}", fecha);
        }
        //Imprime la fecha a partir de un string
        public void printDate(string fecha)
        {
            Console.WriteLine("The day is {0}", fecha);
        }
        //Impime la fecha y un comentario de la misma
       /* public void printDate(DateTime fecha, string comment)
        {
            Console.WriteLine("{0} {1}", comment, fecha);
        }*/
        //Orden distinto compila
        // Esta es un metodo igual al de arriba con los mismos parametros
        // pero ubicados en distinto orden por ende una firma distinta
        public void printDate(string comment, DateTime fecha)
        {
            Console.WriteLine("{0} {1}", comment, fecha);
        }
        // Parametros opcioneles
        public void printDate(DateTime fecha, string comment = "the day is")
        {
            Console.WriteLine("{0} {1}", fecha, comment);
        }
    }
}
