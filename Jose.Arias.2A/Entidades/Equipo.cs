using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #region PROPIEDADES
        public DirectorTecnico DirectorTecnivo
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }
        public string Nombre { get { return this.nombre; } }
        #endregion

        #region CONSTRUCTOR
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region METODOS
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("NombreEquipo:" + e.nombre);
            sb.AppendLine("DirectorTecnico:" + e.directorTecnico);
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
            if (e != j && cantidadMaximaJugadores > e.jugadores.Count && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;

        }
        public static bool ValidarEquipo(Equipo e)
        {
            bool flag = false;
            int contadorArquero = 0;
            int contadorDefensa = 0;
            int contadorCentral = 0;
            int contadorDelantero = 0;
            foreach (Jugador item in e.jugadores)
            {
                if (item.Posicion == EPosicion.Arquero)
                {
                    contadorArquero++;
                }
                if (item.Posicion == EPosicion.Central)
                {
                    contadorCentral++;
                }
                if (item.Posicion == EPosicion.Defensa)
                {
                    contadorDefensa++;
                }
                if (item.Posicion == EPosicion.Delantero)
                {
                    contadorDelantero++;
                }
            }
            if (e.directorTecnico != null && contadorArquero == 1 && contadorCentral > 0 && contadorDefensa > 0 && contadorDelantero >= 0 && cantidadMaximaJugadores == e.jugadores.Count)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
