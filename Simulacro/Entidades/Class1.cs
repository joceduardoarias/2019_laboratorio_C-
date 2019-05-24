using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _documento;

        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public string Documento
        {
            get
            {
                return this._documento;
            }
            set
            {
                bool validar = ValidarDocumentacion(value);
                if(validar)
                {
                    this.Documento = value;
                }
            }
        }
        public Persona(string nombre,string apellido,string documento)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._documento = documento;
        }
        protected abstract bool ValidarDocumentacion(string doc);

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Apellido:" + this.Apellido);
            sb.AppendLine("Documento" + this.Documento);
            return sb.ToString();
        }
    }
}
