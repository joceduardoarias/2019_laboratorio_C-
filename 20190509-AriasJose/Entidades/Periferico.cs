using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public abstract  class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;

        #region CONSTRUCTOR
        public Periferico(string marca,string modelo, EConector conector)
        {
            this.conector = conector;
            this.marca = marca;
            this.modelo = modelo;
        }
        #endregion

        #region METODOS

        public abstract string ExponerDatos();
        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca:" + p.marca);
            sb.AppendLine("Modelo:" + p.modelo);
            sb.AppendLine("Conector:" + p.conector);
            return sb.ToString();
        }
        public static bool operator ==(Periferico uno,Periferico dos)
        {
            bool flag = false;
            if(uno.marca==dos.marca && uno.modelo == dos.modelo)
            {
                flag = false;
            }
            return flag;

        }
        public static bool operator !=(Periferico uno, Periferico dos)
        {
            return !(uno == dos);
        }
        #endregion
    }
}
