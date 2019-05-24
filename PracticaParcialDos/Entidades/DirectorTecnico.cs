using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;
        //PROPIEDADES
        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set
            {
                int años = value;
                this.añosExperiencia = años;
            }
        }
        //METODOS
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosEperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosEperiencia;
        }
        public override bool validarAptitu()
        {
            bool retorno = false;
            if (this.Edad < 65 && this.añosExperiencia >= 2)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("AñosExperiencia:" + this.AñosExperiencia);
            return sb.ToString();
        }

    }
}
