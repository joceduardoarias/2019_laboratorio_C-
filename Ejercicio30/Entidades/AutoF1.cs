using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        #region PROPIEDAD
        public short CaballoDeFuerza
        {
            get {return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region METODOS
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Caballos de Fuerza: " + this.caballosDeFuerza);
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool flag = false;
            if (a1.caballosDeFuerza == a2.caballosDeFuerza )
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


        #endregion
    }
}
