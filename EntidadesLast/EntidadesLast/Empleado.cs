using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLast
{
    public class Empleado
    {

        private string _nombre;
        private int _legajo;
        private float _sueldo;

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set { this._legajo = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public float Sueldo
        {
            get { return this._sueldo; }
            set
            {
                if (value > 12000)
                {
                    this.LimiteSueldo(this, value);//se dispara el evento
                }
                else
                {
                    this._sueldo = value;
                }

            }
        }
        //se disara si el sueldo es mayor a $12000
        //PASO 2
        public event DelegadoSueldo LimiteSueldo;//aqui se va a disparar un evento
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
