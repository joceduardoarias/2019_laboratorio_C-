using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
  public  class Moto:Vehiculo
    {
        protected float _cilindrada;

        //CONSTRUCTOR
        public Moto(string patente, byte cantidadRuedas, Emarcas marca, float cilindrada) : base(patente, cantidadRuedas,marca)
        {
            this._cilindrada = cilindrada;
        }
        //METODOS
        public string MostrarMoto()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarVehiculo());
            sb.AppendLine("Clindrada" + this._cilindrada);
            return sb.ToString();
        }
    }
}

