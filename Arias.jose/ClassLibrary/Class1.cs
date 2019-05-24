using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Boligrafo
    {
        public short cantidadTintaMaxima;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.cantidadTintaMaxima = 100;
            this._tinta = tinta;
            this._color = color;
        }

        public ConsoleColor GetColor()
        {
            return this._color;
        }
        public short GetTinta()
        {
            return this._tinta;
        }
        public void recargar()
        {
            this._tinta = this.cantidadTintaMaxima;
        }
        private void SetTinta(short tinta)
        {
            short aux = 0;
            if (tinta >= -this.cantidadTintaMaxima && tinta <= this.cantidadTintaMaxima)
            {
                aux += tinta; 
            }
            if (aux <= this.cantidadTintaMaxima )
            {
                
                this._tinta = aux;
            }

        }
        public bool pintar(int gasto, out string dibujo)
        {

            bool retorno = false;
            dibujo = "";
            short auxTinta = this.GetTinta();
            
            if ((auxTinta - gasto) >= 0)
            {
                auxTinta -= (short)(gasto);
                this.SetTinta(auxTinta);
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";

                }
                return retorno;
            }
            else
            {   
                Console.WriteLine("Nivel de tinta {0} muy bajo ", this._tinta);
                
                for (int i = 0; i < this._tinta; i++)
                {
                    dibujo += "*";

                }
            }
            return retorno;
        }
    }
}
