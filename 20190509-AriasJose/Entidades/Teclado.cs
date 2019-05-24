using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Teclado:Periferico
    {
        private EDistribucion distribucion;

        #region CONSTRUCTOR
        public Teclado (string marca,string modelo,EConector conector):base(marca,modelo,conector)
        {
            
        }
        public Teclado(string marca, string modelo, EConector conector,EDistribucion distribucion = EDistribucion.Dvorak):this(marca,modelo,conector)
        {
            this.distribucion = distribucion;
        }
        #endregion

        #region METODOS
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TECLADO");
            sb.AppendLine((string)this);
            sb.AppendLine("Distribucion:" + this.distribucion);
            return sb.ToString();
        }
        public static bool operator ==(Teclado t,EDistribucion distribucion)
        {
            bool flag = false;
            if(t.distribucion==distribucion)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);
        }

        #endregion
    }
}
