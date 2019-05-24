using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamo la clase creada
            var myObject = new Constructor_Defoul();
            // Este es instanciada y crea un objeto sin generar algun error
            // pues al no especificar un contrtuctor el diseño de la clase 
            // .Net ha generado uno automaticamente
        }
    }
}
