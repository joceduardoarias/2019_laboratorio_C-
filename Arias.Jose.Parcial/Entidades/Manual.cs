using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Manual:Libro
    {
        protected ETipo tipo;

        #region CONSTRUCTOR
        public Manual(string titulo,float precio, string nombre, string apellido,ETipo tipo):base(titulo,new Autor(nombre,apellido),precio)
        {
            this.tipo = tipo;
        }
        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( Manual.Mostrar(this));
            sb.AppendLine("Tipo:" + this.tipo);
            return sb.ToString();
        }
        public static bool operator ==(Manual m1,Manual m2)
        {
            bool flag = false;
            if( m1.tipo == m2.tipo && m1.Equals(m2))
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }
        public static implicit operator double(Manual m)
        {
            return m._precio;
        }
        #endregion
    }
}
