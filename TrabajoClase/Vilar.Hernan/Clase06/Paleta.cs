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



     

        public Tempera[] MyTemperas
        {
            get {
                return this._temperas;
                    }
            //set { myVar = value; }
        }

        private Paleta(): this(5)
        {

        }
        private Paleta(int cantidad)
        {
            this._cantidadMaxima = cantidad;
            this._temperas = new Tempera[cantidad];
        }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta nuevaPaleta = new Paleta(cantidad);
            return nuevaPaleta;
        }
        private string Mostrar()
        {
            string dato = "";
            dato = this._cantidadMaxima.ToString();
            foreach(Tempera t1 in this._temperas)
            {
                //if((object)t1 != null)
                if (t1!=null)
                    dato += Tempera.Mostrar(t1);   
            }
            return dato;
        }
    
        public static explicit operator string (Paleta p1)
        {
            return p1.Mostrar();
        }
        public static bool operator == (Paleta p1, Tempera t1)
        {
            bool retorno = false;

            for (int i = 0; i<p1._cantidadMaxima;i++)
            {
                if(p1._temperas[i] == t1)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Paleta p1,Tempera t1)
        {
            return (!(p1 == t1));
        }
        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            if(!(p1 == t1))
            {
                p1._temperas[p1.ObtenerIndice()] = t1;
            }
            return p1;
        }
        public static Paleta operator -(Paleta p1,Tempera temp)
        {
            /*
            if((object)p1!=null)
            {
                p1._temperas[index] = null;
            }

            return p1;*/
            for(int i=0;i<p1._cantidadMaxima;i++)
            {
                if(p1._temperas[i] == temp)
                {
                    p1._temperas[i] = null;
                }
            }
            return p1;
        }
        private int ObtenerIndice()
        {
            int retorno = -1;
            for(int i=0;i<this._temperas.Length;i++)
            {
                if(this._temperas[i] == null)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }
    }
}
