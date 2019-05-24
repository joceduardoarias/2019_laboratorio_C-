using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void calculaFinal()
        {
            if(this.nota2 >= 4 && this.nota2 <= 10 && this.nota1 >= 4 && this.nota1 <= 10 )
            {
                Random ramdom;
                ramdom = new Random();
                this.notaFinal = ramdom.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string retorno = "";
            if(this.notaFinal != -1)
            {
                retorno = "\n" + this.nombre + "\n" + this.apellido +"\n"+ "Legajo: "+this.legajo+ "\n"+ "Nota Final:" +this.notaFinal ;
                Console.WriteLine(retorno);
            }
            else
            {
                Console.WriteLine("\n Estudiante  desaprobado");
            }
            return retorno;
        }
        
    }
}
