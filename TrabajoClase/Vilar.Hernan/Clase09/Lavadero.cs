using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehiculos
{
   public class Lavadero
    {
        private List<Vehiculo> lista;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        //PROPIEDADES
        public List<Vehiculo> MyLista {
            get {
               return this.lista;
            }
        }
        public string MyLavadero
        {

            get
            {
                string acumular = "";
                foreach (Vehiculo item in lista)
                {
                    if (item is Auto)
                    {
                        acumular = ((Auto)item).MostrarAuto();
                    }
                    if (item is Moto)
                    {
                        acumular = ((Moto)item).MostrarMoto();
                    }
                    if (item is Camion)
                    {
                        acumular = ((Camion)item).MostrarCamion();
                    }
                }
                return this._precioMoto.ToString()+"-"+ this._precioCamion.ToString() +"-"+ this._precioAuto.ToString()+"-"+
                     acumular;
            }
        }
        //CONSTRUCTOR
        private Lavadero()
        {
            lista = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto,float precioCamion,float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }
        //METODOS
        public static bool operator ==(Lavadero l1,Vehiculo v1)
        {
            bool devolver = false;
            foreach(Vehiculo item in l1.MyLista)
            {
                if(item == v1)
                {
                    devolver = true;
                    break;
                }
            }
            return devolver;
        }
        public static bool operator !=(Lavadero l1, Vehiculo v1)
        {
            return (!(l1 == v1));
        }
        public static Lavadero operator + (Lavadero l1 , Vehiculo v1)
        {
            bool retorno = false;
           for(int i= 0;i<l1.MyLista.Count;i++)
            {
                if(l1.MyLista[i] == v1)
                {
                    retorno = true;
                    break;
                }
            }
           if(retorno == false)
            {
                l1.MyLista.Add(v1);
            }
           return l1;
        }
        public static Lavadero operator -(Lavadero l1, Vehiculo v1)
        {
            
            for (int i = 0; i < l1.MyLista.Count; i++)
            {
                if (l1.MyLista[i] == v1)
                {
                    l1.MyLista.RemoveAt(i);
                    break;
                }
            }
            return l1;
        }
        public double MostrarTotalFacturado()
        {
            double acumulador = 0;
            foreach (Vehiculo item in lista)
            {
                if(item is Moto)
                {
                    acumulador += _precioMoto;
                }
                if (item is Auto)
                {
                    acumulador += _precioAuto;
                }
                if (item is Camion)
                {
                    acumulador += _precioCamion; 
                }
            }
            return acumulador;
        }
        public double MostrarTotalFacturado(Evehiculos vehiculos)
        {
            double acumulador = 0;
            if(vehiculos == Evehiculos.auto)
            {
                foreach (Vehiculo item in lista)
                {
                    if(item is Auto)
                    {
                        acumulador += _precioAuto;
                    }
                }
            }
            if (vehiculos == Evehiculos.camion)
            {
                foreach (Vehiculo item in lista)
                {
                    if (item is Camion)
                    {
                        acumulador += _precioCamion;
                    }
                }
            }
            if (vehiculos == Evehiculos.moto)
            {
                foreach (Vehiculo item in lista)
                {
                    if (item is Moto)
                    {
                        acumulador += _precioMoto;
                    }
                }
            }
            return acumulador;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo v1,Vehiculo v2)
        {
            return v1.Mypatente.CompareTo(v2.Mypatente);                  
        }
        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.Mymarca.CompareTo(v2.Mymarca);
        }
    }
}
