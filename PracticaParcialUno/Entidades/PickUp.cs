using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class PickUp:Vehiculo
    {
        private string modelo;
        private static int valorHora;

        //METODOS

        static PickUp()
        {
            valorHora = 70;
        }
        public PickUp(string patente, string modelo):base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo,int valorHora):this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Modelo:" + this.modelo);
            sb.AppendLine("Valor Hora:" + valorHora);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool flag = false;
            if(obj is PickUp)
            {
                if(((PickUp)obj)==this)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public override string ImprimirTicket()
        {
            double costo;
            double horas;
            horas = (DateTime.Now - this.ingreso).Hours;
            costo = horas * valorHora;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ConsultarDatos());
            sb.AppendLine("Horas:" + horas);
            sb.AppendLine("Costo:" + costo);
            return sb.ToString();
        }
    }
}
