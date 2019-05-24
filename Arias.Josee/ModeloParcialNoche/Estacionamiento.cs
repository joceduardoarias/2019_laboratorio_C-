using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialNoche
{
   public class Estacionamiento
    {
        private int _espcioDiponible;
        private string _nombre;
        private List<Vehiculo> _vehiculos;

        //METODOS
        private Estacionamiento()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre,int espacioDisponible):this()
        {
            this._nombre = nombre;
            this._espcioDiponible = espacioDisponible;
        }
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Espacio Disponible:" + e._espcioDiponible);
            sb.AppendLine("Nombre:" + e._nombre);
            foreach (Vehiculo item in e._vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e,Vehiculo v)
        {
            bool flag = false;
            foreach (Vehiculo item in e._vehiculos)
            {
                if(item == v)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e!=v && v.Patente.Length == 6 && e._espcioDiponible > e._vehiculos.Count)
            {
                e._vehiculos.Add(v);
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();

            if(e==v)
            {
                sb.AppendLine(v.ImprimirTicket());
                e._vehiculos.Remove(v);
            }
            sb.AppendLine("El vehículo no es parte del estacionamiento");
            return sb.ToString();
        }
    }
}
