using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Automovil:Vehiculo
    {
        private string color;
        private static int valorHora;
        //METODOS
        static Automovil()
        {
            valorHora = 50;
        }
        public Automovil(string patente,string color):base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente,string color,int valorHora):this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Color:" + this.color);
            sb.AppendLine("Valor Hora:" + valorHora);
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
            if(obj is Automovil)
            {
                if(((Automovil)obj) == this)
                {
                    flag = true;
                }
            }
            return flag;
        }

    }
}
