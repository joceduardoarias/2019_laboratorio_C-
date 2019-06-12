using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Persona
    {
        public int id;
        public string nombre;
        public string apellido;
        public int edad;
        
        public Persona(int id,string nombre,string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.id = id;
        }
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id:" + this.id);
            sb.AppendLine("Nombre:" + this.nombre);
            sb.AppendLine("Apelldio:" + this.apellido);
            sb.AppendLine("Edad:" + this.edad);
            return sb.ToString();
        }
    }
}
