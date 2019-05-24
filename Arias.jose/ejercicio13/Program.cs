using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            Double valor;
            Console.WriteLine("ingrese un valor");
            valor =Double.Parse( Console.ReadLine());
            binario =Convert.ToString( Conversor.DecimalBinario(valor));
            Console.WriteLine(binario);
        }
    }
}
