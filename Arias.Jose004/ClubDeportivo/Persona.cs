using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
   public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        //PROPIEDADES
        public string Apellido
        {
            get { return this.apellido; }
        }
        public int Dni
        {
            get
            { return this.dni; }
        }
        public int Edad
        {
            get { return this.edad; }
        }
        public string Nombre
        {
            get {return this.nombre; }
        }
        //METODOS
        public Persona(string nombre, string apellido, int edad,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Apellido:" + this.Apellido);
            sb.AppendLine("Dni:" + this.Dni);
            sb.AppendLine("Edad:" + this.Edad);
            return sb.ToString();
        }
        public abstract bool ValidarAptitud();
    }
}
