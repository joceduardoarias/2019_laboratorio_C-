using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLast
{
   public class EmpleadoSueldoArg
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        public string Nombre { get; set; }
        public float Sueldo { get; set; }
        public int Legajo { get; set; }
        //se disara si el sueldo es mayor a $12000
        //PASO 2
        public event DelSueldo LimiteSueldo;//aqui se va a disparar un evento
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Legajo:" + this.Legajo);
            sb.AppendLine("Sueldo:" + this.Sueldo);
            return sb.ToString();
        }
    }
}
