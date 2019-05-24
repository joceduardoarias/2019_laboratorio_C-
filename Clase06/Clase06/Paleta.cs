using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
   public class Paleta
    {

        private Tempera[] _temperas;
        private int _cantidadMaxima;
       
        public Tempera [] MyTempera
        {
            get { return _temperas; }
        }
        //CONTSRUCTOR
        private Paleta() : this(5)
        {

        }
        private Paleta(int cantidad)
        {
            this._temperas = new Tempera[cantidad];
            this._cantidadMaxima = cantidad;
        }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta array;
            return array = new Paleta(cantidad);
        }
        private string Mostrar()
        {
            string retorno = "";

            for (int i = 0; i < this._cantidadMaxima; i++)
            {
                retorno += Tempera.Mostrar(this._temperas[i]);
            }
            return retorno;
        }
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }
        public static bool operator ==(Paleta p, Tempera t)
        {
            bool retorno = false;
            for (int i = 0; i < p._cantidadMaxima; i++)
            {
                if (p._temperas[i] == t)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }
        private int ObtenerIndex()
        {
            int retorno = -1;
            for (int i = 0; i < this._temperas.Length; i++)
            {
                if (this._temperas[i] == null)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }
        public static Paleta operator +(Paleta p, Tempera t)
        {
            if (!(p == t))
            {
                p._temperas[p.ObtenerIndex()] = t;
            }
            return p;
        }



    }
}
