using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public abstract class Persona
    {
        private string apelldio;
        private int dni;
        private int edad;
        private string nombre;
        //PROPIEDADES
        public string Apellido
        {
            get { return this.apelldio; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int Dni
        {
            get {return this.dni;
            }
        }
        public int Edad
        {
            get { return this.edad; }
        }
        //METODOS
        public Persona(string nombre, string apellido,int edad,int dni)
        {
            this.nombre = nombre;
            this.apelldio = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Apellido:" + this.Apellido);
            sb.AppendLine("Edad:" + this.Edad);
            sb.AppendLine("Dni:" + this.Dni);
            return sb.ToString();
        }
        public abstract bool validarAptitu();

    }
}
