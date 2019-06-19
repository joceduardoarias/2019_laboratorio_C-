using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo { get; }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        public Fruta()
        { }

        protected virtual string FrutaToString()
        {
            string resp = "";
            resp += Convert.ToString(this._color) + " " + Convert.ToString(this._peso);
            return resp;
        }
    }
}
