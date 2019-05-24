using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
   public class Lavadero
    {
        private List<Vehiculo> _listaVehiculos;
        private float _precoAuto;
        private float _precioCamion;
        private float _precioMoto;

        //PROPIEDAD
        public List<Vehiculo> MyLista
        {
            get { return this._listaVehiculos; }
        }
        public string MyLavadero
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this._listaVehiculos.Count; i++)
                {
                    if (_listaVehiculos[i] is Auto)
                    {
                        sb.AppendLine(((Auto)this._listaVehiculos[i]).MostrarAuto());
                    }
                    if (_listaVehiculos[i] is Moto)
                    {
                        sb.AppendLine(((Moto)this._listaVehiculos[i]).MostrarMoto());
                    }
                    if (_listaVehiculos[i] is Camion)
                    {
                        sb.AppendLine(((Camion)this._listaVehiculos[i]).MostrarCamion());
                    }
                }
                sb.AppendLine("Precio Auto" + this._precoAuto);
                sb.AppendLine("Precio Moto" + this._precioMoto);
                sb.AppendLine("Precio Camion" + this._precioCamion);
                return sb.ToString();
            }
        }
        
        //CONSTRUCTOR
        private Lavadero()
        {
            _listaVehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioCamion, float precioMoto, float precioAuto)
        {
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
            this._precoAuto = precioAuto;
        }
        //METODOS
        public static bool operator ==(Lavadero lv, Vehiculo v)
        {
            bool retorno = false;
            foreach (Vehiculo item in lv._listaVehiculos)
            {
                if (item == v)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Lavadero lv, Vehiculo v)
        {
            return !(lv == v);
        }
        public static Lavadero operator +(Lavadero lv, Vehiculo v)
        {
            bool retorno = false;
            for (int i = 0; i < lv.MyLista.Count; i++)
            {
                if (lv.MyLista[i] == v)
                {
                    retorno = true;
                }
            }
            if (retorno == false)
            {
                lv.MyLista.Add(v);
            }
            return lv;
        }
        public static Lavadero operator -(Lavadero lv,Vehiculo v)
        {
            for (int i = 0; i < lv.MyLista.Count; i++)
            {

                if (lv.MyLista[i] == v)
                {
                    lv.MyLista.RemoveAt(i);
                    break;
                }
            }
            return lv;
        }
        public double MostrarTotalFacturado()
        {
            double acumulador = 0;
            foreach (Vehiculo item in this.MyLista)
            {
                if(item is Auto)
                {
                    acumulador += this._precoAuto;
                }
                if (item is Moto)
                {
                    acumulador += this._precioMoto;
                }
                if (item is Camion)
                {
                    acumulador += this._precioCamion;
                }
            }
            return acumulador;
        }
        public double MostrarTotalFacturado(EVehiculo TipoVehiculo)
        {
            double acumulador = 0;
            if(TipoVehiculo == EVehiculo.Auto)
            {
                foreach (Vehiculo item in this.MyLista)
                {
                    if (item is Auto)
                    {
                        acumulador += this._precoAuto;
                    }
            }
            }
            if (TipoVehiculo == EVehiculo.Camion)
            {
                foreach (Vehiculo item in this.MyLista)
                {
                    if (item is Camion)
                    {
                        acumulador += this._precioCamion;
                    }
                }
            }
            if (TipoVehiculo == EVehiculo.Moto)
            {
                foreach (Vehiculo item in this.MyLista)
                {
                    if (item is Moto)
                    {
                        acumulador += this._precioMoto;
                    }
                }
            }
            return acumulador;
        }
        public static int OrdenarVehiculoPorPatente(Vehiculo v1,Vehiculo v2)
        {
            return v1.MyPatente.CompareTo(v2.MyPatente);
        }
        public static int OrdenarVehiculoPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.MyMarca.CompareTo(v2.MyMarca);
        }
    }
}
    
