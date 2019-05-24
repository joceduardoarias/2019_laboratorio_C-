using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        //PROPIEDADS
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            { string cadena = value;
                if(cadena.Length == 6)
                {
                    this.patente = cadena;
                }
            }
        }
        //METODOS
        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public abstract string ConsultarDatos();
        public override string ToString()
        {
            return string.Format("Patente:{0}",this.Patente);
        }
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ingreso: " + this.ingreso);
            sb.AppendLine("Hora Ingreso:" + this.ingreso);
            sb.AppendLine(this.ToString());
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            bool flag = false;
            if(v1.patente == v2.patente)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
