using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Vista_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(3, 3, ETipoCompetencia.MotoCross);
            MotoCross moto1 = new MotoCross(1, "yamaha");
            MotoCross moto2 = new MotoCross(2, "honda", 1);
            MotoCross moto3 = new MotoCross(3, "honda", 1);
            AutoF1 autoF1 = new AutoF1(1, "BMW", 122);
            try
            {
                competencia += moto1;
                competencia += moto2;
                competencia += moto3;
                competencia += autoF1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Origen: ");
                Console.WriteLine(e.Source);
                Console.WriteLine("Mensaje: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Antecedente de ejecucion: ");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Texto completo: ");
                Console.WriteLine(e.ToString());
            }
            //completar las excepciones, no se ha logrado establecer la ultima consigina y hay una propiedad que no se 
            //como hacer
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadKey();
        }
    }
}
