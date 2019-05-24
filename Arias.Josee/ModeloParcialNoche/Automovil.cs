using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialNoche
{
    public class Automovil:Vehiculo
    {
        private ConsoleColor _color;
        private static int _valorHora;
        //METODO
         static Automovil()
        {
            _valorHora=50;
        }
        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            this._color = color;
        }
        public Automovil(string patente,ConsoleColor color, int valorHora):this(patente, color)
        {
            _valorHora = valorHora;            
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Color:" + this._color);
            sb.AppendLine("Valor Hora:" + _valorHora);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Automovil)
            {
                if (((Automovil)obj) == this)
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
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine("costo:" + costo);
            return sb.ToString();
        }

    }
}
