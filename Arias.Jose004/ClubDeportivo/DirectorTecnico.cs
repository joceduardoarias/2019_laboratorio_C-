using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        //PROPIEDADES
        public int AñosEperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        public DirectorTecnico(string nombre, string apellido,int edad,int dni ,int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (this.añosExperiencia > 2 && this.Edad <= 65)
            {
                retorno = true;
            }
            return retorno;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Años Eperiencia:" + this.AñosEperiencia);
            return sb.ToString();
        }

    }
}
