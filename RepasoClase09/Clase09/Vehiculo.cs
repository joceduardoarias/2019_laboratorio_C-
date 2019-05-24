using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
    public class Vehiculo
    {
        protected string patente;
        protected Emarcas marca;
        protected byte cantidadRuedas;

        public string Mypatente
        {
            get
            {
                return this.patente;
            }
        }

        public Emarcas Mymarca
        {
            get
            {
                return this.marca;
            }
        }


        protected string MostrarVehiculo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this.Mypatente);
            sb.AppendLine("Marca: " + this.Mymarca);
            sb.AppendLine("Cantidad de Ruedas: " + this.cantidadRuedas);
            return sb.ToString();
        }
        public Vehiculo(string patente, byte cantidadRuedas, Emarcas marca)
        {
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (v1.patente == v2.patente && v1.marca == v2.marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1 == v2));
        }
    }
}
