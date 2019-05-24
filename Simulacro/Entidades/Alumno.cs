using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private eDivision division;

        public string AnioDision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Anio: " + this.anio);
                sb.AppendLine("Division: " + this.division);
                return sb.ToString();
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, eDivision division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        //METODOS
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(AnioDision);
            sb.AppendLine(base.ExponerDatos());
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = true;

            if (doc.Length != 9)
                valida = false;

            else
            {
                int numero;
                bool esNum;

                for (int i = 0; i < doc.Length; i++)
                {
                    esNum = int.TryParse(doc[i].ToString(), out numero);

                    if (!esNum)
                    {
                        if (doc[i] != '-')
                        {
                            valida = false;
                            break;
                        }
                        else
                        {
                            if (i != 2)
                            {
                                if (i != 7)
                                {
                                    valida = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return valida;
        }
    }
}
