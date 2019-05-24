using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialNoche
{
   public class Moto:Vehiculo
    {
        private int _cilindrada;
        private short ruedas;
        private static int _valorHora;

        //METODOS
        static Moto()
        {
            _valorHora = 30;
        }
        public Moto(string patente,int cilindrada):base(patente)
        {
            this._cilindrada = cilindrada;
            this.ruedas = 2;
        }
        public Moto(string patente,int cilindrada,short ruedas):this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada,short ruedas,int valoHora):this(patente,cilindrada,ruedas)
        {
            _valorHora = valoHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cilindrada:" + this._cilindrada);
            sb.AppendLine("Ruedas:" + this.ruedas);
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            int horas;
            float costo;
            horas = (DateTime.Now - base.ingreso).Hours;
            costo = horas * _valorHora;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine("costo:" + costo);

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Moto)
            {
                if (((Moto)obj) == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
