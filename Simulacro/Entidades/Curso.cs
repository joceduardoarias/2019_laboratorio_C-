using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumno;
        private short anio;
        private eDivision division;
        private Profesor profesor;
        //PROPIEDADES
        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Año: " + this.anio.ToString());
                sb.AppendLine("Dvision: " + this.division);
                return sb.ToString();
            }
        }
        //METODOS
        public Curso()
        {
            alumno = new List<Alumno>();
        }
        public Curso(short anio,eDivision division,Profesor profesor)
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public static explicit operator string(Curso curso)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Profesor: " + curso.profesor.ExponerDatos());
            sb.AppendLine(curso.AnioDivision);
            foreach (Alumno item in curso.alumno )
            {
                sb.AppendLine(item.ExponerDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Alumno alumno,Curso curso)
        {
            bool retorno = false;
            if(alumno.AnioDision == curso.AnioDivision)
            {
                retorno = true;
            }
           return retorno;
        }
        public static bool operator !=(Alumno alumno,Curso curso)
        {
            return !(alumno == curso);
        }
        public static Curso operator +(Alumno alumno, Curso curso)
        {
            if(alumno == curso)
            {
                curso.alumno.Add(alumno);
            }
            return curso;
        }
    }
}
