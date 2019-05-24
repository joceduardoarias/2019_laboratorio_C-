using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
        
        public Cosa ()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int entero) : this()
        {
            this.entero = entero;
        }
        public Cosa (int entero, DateTime fecha):this(entero)
        {
            this.fecha = fecha;
        }
        public Cosa (int entero,DateTime fecha, string cadena):this(entero, fecha)
        {
            this.cadena = cadena;
        }
        
        /*
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int entero)
        {
            this.entero = entero;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;

        }
        public Cosa(int entero, DateTime fecha)
        {
            this.entero = entero;
            this.cadena = "sin valor";
            this.fecha = fecha;
        }
        public Cosa(int entero, DateTime fecha, string cadena)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = fecha;

        }*/




        public string Mostrar()
        {
            string devolver = "";
            devolver += this.entero.ToString() + "-" + this.cadena + "-" + this.fecha.ToString();
            return devolver;
        }
        public static string Mostrar(Cosa dato)
        {
            string devolver = "";
            devolver = dato.Mostrar();
            return devolver;
        }
        public void EstablecerValor(int dato)
        {
            this.entero = dato;
        }
        public void EstablecerValor(string dato)
        {
            this.cadena = dato;
        }
        public void EstablecerValor(DateTime dato)
        {
            this.fecha = dato;
        }
    }
}
