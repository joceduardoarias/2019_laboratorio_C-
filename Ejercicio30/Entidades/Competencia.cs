using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipoCompetencia;

        #region PROPIEDADES
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public ETipoCompetencia TipoCompetencia
        {
            get { return this.tipoCompetencia; }
            set { this.tipoCompetencia = value; }
        }

        #endregion

        #region CONSTRUCTOR
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipoCompetencia) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipoCompetencia = tipoCompetencia;
        }
        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CantidadVueltas: " + this.cantidadVueltas);
            sb.AppendLine("CantidadCompetidores: " + this.cantidadCompetidores);
            foreach (VehiculoDeCarrera item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool flag = false;
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if (a is MotoCross)
                {
                    if (item is MotoCross && ((MotoCross)item) == ((MotoCross)a))
                    {
                        flag = true;
                        break;
                    }
                }
                if (a is AutoF1)
                {
                    if (item is AutoF1 && ((AutoF1)item) == ((AutoF1)a))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if(flag)
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia","Competencia","Sobrecarga operador +");
            }
            return flag;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public static Competencia operator +(Competencia c, VehiculoDeCarrera a)
        {
            

            if (c.competidores.Count <= c.cantidadCompetidores)
            {
                try
                {
                    if (c.TipoCompetencia == ETipoCompetencia.MotoCross && a is MotoCross && c != a)
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        Random vuelta = new Random();
                        a.CantidadCombustible = (short)vuelta.Next(15, 100);
                        a.VueltasRestantes = c.cantidadVueltas;

                    }
                    if (c.TipoCompetencia == ETipoCompetencia.F1 && a is AutoF1 && c != a)
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        Random vuelta = new Random();
                        a.CantidadCombustible = (short)vuelta.Next(15, 100);
                        a.VueltasRestantes = c.cantidadVueltas;

                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {

                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +",e);
                }
                
            }

            //if (!flag)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine("El vehículo no corresponde a la competencia");
            //    throw new CompetenciaNoDisponibleException(sb.ToString(), "Clase Competencia", "Sobrecarga operador '+'");
            //}
            return c;
        }
        public static Competencia operator -(Competencia c, VehiculoDeCarrera v)
        {
            c.competidores.Remove(v);
            return c;
        }
        #endregion
    }
}
