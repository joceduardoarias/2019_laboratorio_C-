using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            persona myObj = new persona();
            persona myObj1 = new persona();
            Juego lanzar = new Juego();
            
            myObj.Nombre = "Jose";
            myObj1.Nombre = "camilo";
            myObj.Saludar(myObj.Nombre);
            myObj1.Saludar(myObj1.Nombre);

            lanzar.Lanzar();
        }
    }
}
