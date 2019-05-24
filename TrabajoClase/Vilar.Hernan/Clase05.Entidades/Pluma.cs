using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Pluma
    {
        string _marca;
        Tinta _tinta;
        int _cantidad;


        public Pluma() : this("bic", null, 20)
        {

        }
        public Pluma(string marca):this( marca ,null,20)
        {

        }
        public Pluma(string marca, Tinta tinta): this(marca,tinta,20)
        {

        }
        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }
        private string mostrar()
        {
            return  this._marca.ToString() +  "-" +this._cantidad.ToString() + "-" + Tinta.Mostrar(this._tinta);
        }
        public static bool operator == (Pluma dato1, Tinta dato2)
        {
            return dato1._tinta == dato2;
        }
        public static bool operator != (Pluma dato1,Tinta dato2)
        {
            return !(dato1 == dato2);
            
        }
        public static implicit operator string(Pluma p) //public static o eplicit o implicit operator tipo()
        {
            return p.mostrar();
        }
        public static Pluma operator + (Pluma pluma, Tinta tinta)
        {
            if(pluma == tinta && pluma._cantidad <100)
            {
                pluma._cantidad = pluma._cantidad + 10;
            }
            return pluma;
        }
        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma._cantidad < 100)
            {
                pluma._cantidad = pluma._cantidad - 10;
            }
            return pluma;
        }

    }
}
