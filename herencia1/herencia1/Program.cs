using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    class Program
    {
        static void Main(string[] args)
        {   //Instaciando la clase Personal
            Personal myObj = new Personal(1,"jose","arias");
            //Instanciando la clase Profesor
            profesor myTeacher = new profesor(2, "elidia", "Melo","La esperanza");
            /*Como podemos apreciar aunque la clase profesor (Hija) no contiene campos hereda
             *de la clase personal (Padre) los campos, si los llenamos no habrá problemas.
             *Imprimir el objeto */
            Console.WriteLine("Clase padre Personal");
            Console.WriteLine("Profesor1: {0} {1} {2}",myObj.Id, myObj.Nombre,myObj.Apellido);
            Console.ReadLine();
            Console.WriteLine("Clase hija Profesor");
            Console.WriteLine("Profesor2: {0} {1} {2} {3}", myTeacher.Id, myTeacher.Nombre, myTeacher.Apellido,myTeacher.direc);
            /*Esta variable esta inicializada en el padre y es posible utilizarla
              atraves del hijo*/
            Console.WriteLine(myTeacher.comment);
            //Llamando al metdo del padre clase Personal
            Console.WriteLine("Resultado Metodo Padre: {0}", myObj.Suma(5, 6));
            //Llamando al metdo del hijo clase Profesor
            Console.WriteLine("Resultado Metodo Padre: {0}", myTeacher.Suma(1, 5, 6));
        }
    }
}
