using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        private DateTime fechaIngreso;

        //PROPIEDAD

        public int  Antiguedad
        {
            get
            {
                TimeSpan ts = new TimeSpan();
                ts = DateTime.Now - this.fechaIngreso;
                int dias = ts.Days;

                return dias;
            }
        }
        //METODOS
        public Profesor(string nombre,string apellido,string documento):base(nombre,apellido,documento)
        {

        }
        public Profesor(string nombre,string apellido,string documento,DateTime antiguedad):base(nombre,apellido,documento)
        {
            this.fechaIngreso = antiguedad;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = true;

            if (doc.Length != 8)
                valida = false;

            return valida;
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Antiguedad:" + this.Antiguedad.ToString());
            sb.AppendLine(base.ExponerDatos());
            return sb.ToString();
        }
    }
}
