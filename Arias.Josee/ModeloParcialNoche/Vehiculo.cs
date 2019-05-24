using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialNoche
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string _patente;
        //PROPIEDADES
        public string Patente
        {
            get
            {
                return this._patente;
            }

            set
            {
                string cadena = value;
                if (cadena.Length == 6)
                {
                    this._patente = cadena;
                }
            }
        }
        //METODOS
        public Vehiculo (string patente)
        {
            this._patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("Patente:{0}", this.Patente);
        }
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ToString());
            sb.AppendLine("Fecha:" + this.ingreso);
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            bool retorno = false;
            if(v1.Patente == v2.Patente && v1.Equals(v2))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
