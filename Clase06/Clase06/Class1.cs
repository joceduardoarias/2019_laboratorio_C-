using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    #region Tempera
    public class Tempera
    {
        private ConsoleColor _color;
        private string _Marca;
        private sbyte _cantidad;
        //Constructor

        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._cantidad = cantidad;
            this._color = color;
            this._Marca = marca;
        }

        private string Mostrar()
        {
            string retorno = this._color.ToString() + " " + this._cantidad.ToString() + " " + this._Marca;
            return retorno;
        }
        public static string Mostrar(Tempera t)
        {
            string retorno = "";
            if (t != null)
                retorno = t.Mostrar();
            return retorno;
        }
        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool retorno = false;
            if ((Object.Equals(t1, null)) && (Object.Equals(t2, null)))
            { //si tempera 1 y tempera 2 son nulas

                retorno = true;
                //retorno true
            }
            else if (Object.Equals(t1, null) || (Object.Equals(t2, null)))
            {// si uno de los dos no es null
                retorno = false;
                // solo son iguales cuando los dos son distintos de null
            }
            else
            {
                if (t2._color == t1._color && t2._Marca == t1._Marca)
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
            return !(t1 == t2);
        }
        public static Tempera operator +(Tempera t1, sbyte cantidad)
        {
            //t1._cantidad += (sbyte)(t1._cantidad + cantidad);
            //return t1;
            t1._cantidad += cantidad;
            return t1;
        }
        /// <summary>
        /// Suma(Tempera, Tempera). Recarga la tinta si las dos temperas son iguales.
        /// </summary>
        /// <param name="t1">tempera1</param>
        /// <param name="t2">tempera2</param>
        /// <returns>tempera recargada</returns>
        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
                t1 += t2._cantidad;
            return t1;
        }
        public static implicit operator sbyte(Tempera t)
        {
            return t._cantidad;
        }
    }
    #endregion
}
