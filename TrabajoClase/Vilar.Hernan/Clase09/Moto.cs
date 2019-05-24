using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto:Vehiculo
    {
      
        public double cilindrada;

        public Moto(string patente, Byte cantidadRuedas, EMarca marca, double cilindrada):base(patente,cantidadRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }
        public string MostrarMoto()
        {
            string devolver;
            devolver = base.MostrarVehiculo() + this.cilindrada.ToString();
            return devolver;
        }
    }
}
