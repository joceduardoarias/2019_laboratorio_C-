using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;
        //METODOS
        static Moto()
        {
            valorHora = 30;
        }
        public Moto(string patente,int cilindrada):base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }
        public Moto(string patente,int cilindrada,short ruedas):this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cilindrada:" + this.cilindrada);
            sb.AppendLine("Ruedas:" + this.ruedas);
            sb.AppendLine("Valor Horas:" + valorHora);
            return sb.ToString();
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
        public override bool Equals(object obj)
        {
            bool flag = false;
            if(obj is Moto)
            {
                if(((Moto)obj)==this)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
