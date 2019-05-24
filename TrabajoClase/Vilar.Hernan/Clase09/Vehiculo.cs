using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        protected string patente;
        protected EMarca marca;
        protected byte cantidadRuedas;

        public string Mypatente
        {
            get
            { return  this.patente;
            }
        }

        public EMarca Mymarca
        {
            get
            {
                return this.marca;
            }
        }
        //set;

        protected string MostrarVehiculo()
        {
            string devolver;
            devolver = this.patente + this.marca.ToString() + this.cantidadRuedas.ToString();
            return devolver;
        }
        public Vehiculo(string patente, byte cantidadRuedas, EMarca marca)
        {
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if(v1.patente == v2.patente && v1.marca == v2.marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1,Vehiculo v2)
        {
            return (!(v1 == v2));
        }
    }
}
