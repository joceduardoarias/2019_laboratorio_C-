using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public abstract  class Persona
    {
        private string nombre;
        private int dni;
        private int edad;
        private string apellido;

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } }
        public int Dni { get { return this.dni; } }
        public int Edad { get {return this.edad; }  }
        public string Apellido { get { return this.apellido; }  }
        #endregion

        #region CONSTRUCTOR
       public Persona(string nombre,string apellido,int edad,int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
        }
        #endregion

        #region METODOS
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.nombre);
            sb.AppendLine("Apellido:" + this.apellido);
            sb.AppendLine("Edad:" + this.edad);
            sb.AppendLine("Dni:" + this.dni);
            return sb.ToString();
        }
        public abstract bool ValidarAptitud();
        
        #endregion
    }
}
