using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3
{
    class libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
    }
}
