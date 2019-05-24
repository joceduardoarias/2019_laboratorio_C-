using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;
        //METODOS
        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + e.nombre);
            sb.AppendLine("EspacioDisponible:" + e.espacioDisponible);
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool flag = false;
            foreach (Vehiculo item in e.vehiculos)
            {
                if (item == v)
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
            if (e != v && v.Patente != null && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            if (e == v)
            {

                flag = true;
            }

            if (flag == true)
            {
                sb.AppendLine( v.ImprimirTicket());
                e.vehiculos.Remove(v);
            }
            else
            {
              sb.AppendLine("El Vehiculo no es parte del estacionamiento");
            }

            return sb.ToString();
        }
    }
}

