using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Autor
    {
        private string nombre;
        private string apellido;

        //METODOS
        public Autor(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static implicit operator string(Autor a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE:" + a.nombre);
            sb.AppendLine("APELLIDO:" + a.apellido);
            return sb.ToString();
        }
        public static bool operator ==(Autor a, Autor b)
        {
           return  (a.nombre == b.nombre && a.apellido == b.apellido) ;         
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
    }
}
