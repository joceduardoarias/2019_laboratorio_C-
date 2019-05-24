using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;

        #region PROPIEDADES
        public int CantidadMaximaPerifericos
        {
            get { return this.cantidadMaxPerifericos; }
            set
            {
                int cantidad = value;
                if (cantidad >= 1 && cantidad <= 4)
                {
                    this.cantidadMaxPerifericos = cantidad;
                }
                else if(cantidad < 1)
                {
                    this.cantidadMaxPerifericos = 1;
                }
                else
                {
                    this.cantidadMaxPerifericos = 4;
                }
            }
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string SystemInfo
        { get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Nombre Maquina:" + this.nombre);
                foreach (Periferico item in this.perifericos)
                {
                    sb.AppendLine(item.ExponerDatos());
                }
                return sb.ToString();
            }
        }
        #endregion

        #region CONSTRUCTOR
        private Maquina()
        {
            perifericos = new List<Periferico>();
            this.CantidadMaximaPerifericos = 3;
        }
        public Maquina(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region METODOS
        public static bool operator ==(Maquina m, Periferico p)
        {
            bool flag = false;
            foreach (Periferico item in m.perifericos)
            {
                if (item == p)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }
        public static Maquina operator +(Maquina m, Periferico p)
        {
            if (m != p)
            {
                m.perifericos.Add(p);
                Console.WriteLine("Periferico conectado!");
            }
            else
            {
                Console.WriteLine("No se puede conectar el dispositivo.");
            }
            return m;
        }
        public static Maquina operator -(Maquina m, Periferico p)
        {
            if (m == p)
            {
                m.perifericos.Remove(p);
                Console.WriteLine("Periferico desconectado!");
            }
            else
            {
                Console.WriteLine("No se puede desconectar el dispositivo.");
            }
            return m;
        }
        #endregion
    }
}
