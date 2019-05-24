using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno obj1;
            obj1 = new Alumno();
            obj1.apellido = "Perez";
            obj1.nombre = "Juan";
            obj1.legajo = 001;
            obj1.estudiar(20, 13);
            obj1.calculaFinal();
            obj1.Mostrar();

            Alumno obj2;
            obj2 = new Alumno();
            obj2.apellido = "Vargas";
            obj2.nombre = "Jose";
            obj2.legajo = 002;
            obj2.estudiar(4,6);
            obj2.calculaFinal();
            obj2.Mostrar();

            Alumno obj3;
            obj3 = new Alumno();
            obj3.apellido = "Martinez";
            obj3.nombre = "Camilo";
            obj3.legajo = 003;
            obj3.estudiar(4, 8);
            obj3.calculaFinal();
            obj3.Mostrar();
        }
    }
}
