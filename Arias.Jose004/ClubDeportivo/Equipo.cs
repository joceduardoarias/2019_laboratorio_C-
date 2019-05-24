using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private List<Jugador> jugadores;
        private string nombre;
        private DirectorTecnico directorTecnico;

        //PROPIEDAD
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        //METODOS
        private Equipo()
        {
           this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Equipo:" + e.Nombre);
            sb.AppendLine("Director Tecnico:" + e.directorTecnico);
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int contadorArqueros = 0;
            int contadorDefensa = 0;
            int contadorCentral = 0;
            int contadorDelantero = 0;
            foreach (Jugador item in e.jugadores)
            {
                if (item.Posicion == Posicion.Arquero)
                {
                    contadorArqueros++;
                }
                if (item.Posicion == Posicion.Central)
                {
                    contadorCentral++;
                }
                if (item.Posicion == Posicion.Defensor)
                {
                    contadorDefensa++;
                }
                if (item.Posicion == Posicion.Delantero)
                {
                    contadorDelantero++;
                }
            }
            if (e.directorTecnico != null &&contadorArqueros == 1 && contadorCentral > 0 && contadorDefensa > 0 && contadorDelantero > 0 && cantidadMaximaJugadores == e.jugadores.Count)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
