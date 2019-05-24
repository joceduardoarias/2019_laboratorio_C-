using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 's';
            int valor;

            while(ValidarRespuesta.ValidarS_N(respuesta))
            {
                Console.WriteLine("Ingrese un numero: ");
                valor = int.Parse( Console.ReadLine());
                Console.WriteLine("continuar S/N");
                respuesta = char.Parse( Console.ReadLine());
            }

        }
    }
}
