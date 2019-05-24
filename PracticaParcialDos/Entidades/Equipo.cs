using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directoTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        //PROPIEDADES
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.validarAptitu())
                    this.directoTecnico = value;
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        //METODOS
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Equipo:" + e.Nombre);
            sb.AppendLine("DrTecnico:" + e.directoTecnico);
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool flag = false;
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < 6 && j.validarAptitu())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            bool flag = false;
            int contadorArquero = 0;
            int contadorCentral = 0;
            int contadorDefensa = 0;
            int contadorDelantero = 0;
            foreach (Jugador item in e.jugadores)
            {
                if (Posicion.Arquero == item.Posicion)
                {
                    contadorArquero++;
                }
                if (Posicion.Defensor == item.Posicion)
                {
                    contadorDefensa++;
                }
                if (Posicion.Central == item.Posicion)
                {
                    contadorCentral++;
                }
                if (Posicion.Delantero == item.Posicion)
                {
                    contadorDelantero++;
                }
            }
            if (e.directoTecnico != null && contadorDelantero > 0 && contadorDefensa > 0 && contadorCentral > 0 && contadorArquero == 1 && e.jugadores.Count == cantidadMaximaJugadores)
            {
                flag = true;
            }
            return flag;
        }
    }
}
