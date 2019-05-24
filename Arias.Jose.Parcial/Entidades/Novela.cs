using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Novela:Libro
    {
        protected EGenero genero;

        #region CONSTRUCTOR
        public Novela(string titulo,float precio,Autor autor,EGenero genero):base(titulo,autor,precio)
        {
            this.genero = genero;
        }
        #endregion
        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Novela.Mostrar(this));
            sb.AppendLine("Genero:" + this.genero);
            return sb.ToString();
        }
        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
        public static bool operator ==(Novela n1,Novela n2)
        {
            bool flag = false;
            if(n1.Equals(n2) && n1.genero==n2.genero)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }
        #endregion
    }
}
