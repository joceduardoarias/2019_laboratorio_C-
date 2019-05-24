using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto:Vehiculo
    {
       
        public int cantidadAsientos;

        public Auto(string patente, Byte cantidadRuedas, EMarca marca,int cantidadAsientos):base(patente,cantidadRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        public string MostrarAuto()
        {
            string devolver;
            devolver = base.MostrarVehiculo() + this.cantidadAsientos.ToString();
            return devolver;
        }
    }
}
