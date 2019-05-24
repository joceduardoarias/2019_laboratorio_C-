using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, i, debajonum, encimanum, entrada;
            i = 2;
            Console.WriteLine("Ingrese un numero");
            entrada = int.Parse(Console.ReadLine());
            while (i <= 5000)
            {
                debajonum = 0;
                encimanum = 0;
                w = 1;
                while (w < i)
                {
                    debajonum = debajonum + w;
                    w = w + 1;
                }
                while (debajonum > encimanum)
                {
                    w = w + 1;
                    encimanum = encimanum + w;
                }
                if (debajonum == encimanum)
                {
                    Console.WriteLine(i.ToString("#,###.00"));
                }
                i++;
            }
        }
    }
}
