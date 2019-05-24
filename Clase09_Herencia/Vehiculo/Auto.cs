using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
  public  class Auto: Vehiculo
    {
        protected int _cantidadAsiento;

        //CONSTRUCTOR

        public Auto(string patente,byte cantidadRuedas ,Emarcas marca,int cantidadAsientos):base(patente,marca,cantidadRuedas)
        {
            this._cantidadAsiento = cantidadRuedas;
        }

        //METODOS
        public string MostrarAuto()
        {
           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de Asientos:" + this._cantidadAsiento);
            return sb.ToString();
        }
    }
}
