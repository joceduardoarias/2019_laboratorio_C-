using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia { get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; } }

        #region CONSTRUCTOR
        public DirectorTecnico(string nombre,string apellido,int edad,int dni, int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        #endregion

        #region METODOS
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Años experincia:" + this.añosExperiencia);
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool flag = false;
            if(this.Edad <65 && this.añosExperiencia >= 2)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
