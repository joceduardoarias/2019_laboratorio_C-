using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Sello
    {
        public static  string mensaje;
        public static ConsoleColor color;
    

        
        public static string Imprimir()
        {
            //return Sello.mensaje"";
            return Sello.ArmarFormatoMensaje();
           
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Sello.color = ConsoleColor.Cyan;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        private static string ArmarFormatoMensaje()
        {
            int dato;
            int i;
            string techo = "";
            dato = Sello.mensaje.Length;
            for(i=0;i<dato+2;i++)
            {
                techo += "*";
            }
            techo += "\n*" + Sello.mensaje + "*\n" + techo;
            
            return techo;
        }
}
}
