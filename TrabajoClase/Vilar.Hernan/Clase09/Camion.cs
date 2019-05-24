using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion: Vehiculo
    {
        public float _tara;
        
        
        public Camion (string patente,Byte cantidadRuedas, EMarca marca,float tara):base(patente,cantidadRuedas,marca)
            {
            this._tara = tara;
            }
       public string MostrarCamion()
        {
            string devolver;
            devolver = base.MostrarVehiculo() + this._tara.ToString();
            return devolver;   
        }

       
    }
}
