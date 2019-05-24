using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialNoche
{
   public class PickUp:Vehiculo
    {
        private string _modelo;
        static int _valorHora;

        static PickUp()
        {
            _valorHora = 70;
        }
        public PickUp(string patente,string modelo):base(patente)
        {
            this._modelo = modelo;
        }
        public PickUp(string patente,string modelo,int valorHora):this(patente,modelo)
        {
            _valorHora=valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ToString());
            sb.AppendLine("Modelo:" + this._modelo);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is PickUp)
            {
                if (((PickUp)obj) == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public override string ImprimirTicket()
        {
            int horas;
            float costo;
            horas = (DateTime.Now - base.ingreso).Hours;
            costo = horas * _valorHora;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine("costo:" + costo);
            return sb.ToString();
        }

    }
}
