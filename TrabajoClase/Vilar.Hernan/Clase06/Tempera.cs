using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        public string MyMarca {
            
            get
            {
                return this._marca;
            }
        }
        public ConsoleColor MyColor {
            get
            {
                return this._color;
            }
        }
        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }
        private string Mostrar()
        {
            return this._color.ToString() + "-" + this._marca.ToString() + "-" + this._cantidad.ToString(); ;
        }
        public static string Mostrar(Tempera tempera)
        {
            string devolver = "";

            if(tempera!=null)
            {
                devolver = tempera.Mostrar();
            }
            return devolver;
        }
        public static bool operator == (Tempera t1, Tempera t2)
        {
            bool retorno = false;
            if ((object.Equals(t1, null)) && (object.Equals(t2,null)))
            {
                retorno = true;
            }
            
            else if((object.Equals(t1,null)) || object.Equals(t2,null))
            {
                retorno = false;
            }
            else
            {
                if(t1._color == t2._color && t2._marca == t1._marca)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return (!(t1 == t2));
        }
        public static Tempera operator +(Tempera t1,sbyte cantidad)
        {
            t1._cantidad = (sbyte)(t1._cantidad + cantidad);
            return t1;
        }
        public static Tempera operator + (Tempera t1,Tempera t2)
        {
            if(t1 == t2)
            {
                t1 = t1 + t2._cantidad;
            }
            return t1;
        }
        public static implicit operator sbyte(Tempera t1)
        {
            return t1._cantidad;
        }
       
    }
}
