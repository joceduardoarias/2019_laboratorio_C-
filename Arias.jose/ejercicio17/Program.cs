using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo = "";
            Boligrafo objBlue;
            Boligrafo objRed;
            objBlue = new Boligrafo(100,ConsoleColor.Blue);
            objRed = new Boligrafo(50, ConsoleColor.Red);

            objBlue.pintar(20, out dibujo);
            Console.ForegroundColor = objBlue.GetColor();
            Console.WriteLine(dibujo);

            objRed.pintar(150, out dibujo);
            Console.ForegroundColor = objRed.GetColor();
            Console.WriteLine(dibujo);
        }
    }
}
