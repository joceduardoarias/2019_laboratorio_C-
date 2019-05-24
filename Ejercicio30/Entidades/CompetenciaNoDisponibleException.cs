using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string  NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }

        public CompetenciaNoDisponibleException(string mensaje,string nombreClase, string nombreMetodo):base(mensaje)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }
        public CompetenciaNoDisponibleException(string mensaje,string nombreClase, string nombreMetodo,Exception innerexception) : base(mensaje,innerexception)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }

        public override string ToString()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}:", this.NombreMetodo,this.NombreClase);
            
            return sb.ToString();
        }
    }
}
