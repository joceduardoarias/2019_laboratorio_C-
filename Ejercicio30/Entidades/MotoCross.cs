using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero,string escuderia):base(numero,escuderia)
        {

        }
        public MotoCross(short numero, string escuderia,short cilindrada):this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cilindrada: " + this.Cilindrada);
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool flag = false;
            if (m1.cilindrada == m2.cilindrada )
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
