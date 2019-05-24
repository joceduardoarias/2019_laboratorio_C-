using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
    public class Camion:Vehiculo
    {
        protected float _tara;

        //CONSTRUCTOR
        public Camion(string patente, Emarcas marca, byte cantidaRuedas, float tara) : base(patente,cantidaRuedas,marca)
        {
            this._tara = tara;
        }
        //METODOS
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarVehiculo());
            sb.AppendLine("Tara: " + this._tara);
            return sb.ToString();
        }
    }
}
