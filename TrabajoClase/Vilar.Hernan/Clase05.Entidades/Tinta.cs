using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipotinta;

        public Tinta():this(ConsoleColor.Black,ETipoTinta.Comun)
        {
            //this._color = ConsoleColor.Black;
            //this._tipotinta = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color):this(color,ETipoTinta.Comun)
        {
        }
        public Tinta(ConsoleColor color, ETipoTinta tinta)
        {
            this._tipotinta = tinta;
            this._color = color;
        }
        private  string Mostrar()
        {
            return this._color.ToString() + "-" + this._tipotinta.ToString();
        }
        public static string Mostrar(Tinta dato)
        {
            return dato.Mostrar();
        }
        public static bool operator == (Tinta dato, Tinta dato2)
         {
            bool retorno = false;
            if(dato._tipotinta == dato2._tipotinta && dato._color == dato2._color)
            {
                retorno = true;
            }
            return retorno;
         }
        public static bool operator != (Tinta dato, Tinta dato2)
        {
            return !(dato == dato2);
        }
    }
}
