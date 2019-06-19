using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Platano : Fruta
    {
        public string paisOrigen;

        public Platano(float peso, ConsoleColor color, string pais)
            :base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo { get { return "Platano"; } }

        protected override string FrutaToString()
        {
            string resp = "";
            resp += base.FrutaToString() + " " + this.Tipo + " " + this.paisOrigen;
            return resp;
        }

        public override string ToString()
        {
            string r = "";
            r += this.FrutaToString();
            return r;
        }
    }
}
