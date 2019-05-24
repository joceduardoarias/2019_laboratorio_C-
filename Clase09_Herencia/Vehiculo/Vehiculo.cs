using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _canRuedas;
        protected Emarcas _marca;

        //PROPIEDAD

        public string MyPatente
        {
            get
            {
                return _patente;
            }
        }
        public string MyMarca
        {
            get
            { return this._marca.ToString(); }
        }
        //CONSTRUCTOR
        public Vehiculo(string patente, Emarcas marca,byte cantidaRuedas)
        {
            this._marca = marca;
            this._patente = patente;
            this._canRuedas = cantidaRuedas;
        }
        //METODOS
        protected string Mostrar()
        {
            StringBuilder sb =new StringBuilder();
            sb.AppendLine("Patente: " + this._patente);
            sb.AppendLine("Marca: " + this._marca);
            sb.AppendLine("Cantidad de Ruedas: " + this._canRuedas);
            return sb.ToString();
        }
        //SOBRECARGA OPERADORES
        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            bool retorno = false;
            if(v1._patente == v2._patente && v1._marca == v2._marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1,Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
