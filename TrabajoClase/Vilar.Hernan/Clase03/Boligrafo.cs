using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boli
{
    class Boligrafo
    {
        public short cantidadMaxima;
        private ConsoleColor _color;
        private short _tinta;
        


        public Boligrafo(ConsoleColor color,short tinta)
        {
            this.cantidadMaxima = 100;
            this._color = color;
            this._tinta = tinta;
            Console.ForegroundColor = _color;
        }
        public ConsoleColor GetColor()
        {
            return this._color;
        }
        public short GetTinta()
        {
            return this._tinta;
        }
        public bool Pintar(int gasto,out string dibujar)
        {
            int aux;
            int i;
            dibujar = "";
            bool devolver = false;

            aux = this.GetTinta();

            this.SetTinta((short)gasto);

            if(aux != this.GetTinta())
            {
                for(i = 0; i!=gasto;i++)
                {
                    dibujar += "*";
                    gasto = gasto + 2;
                }
                
                devolver = true;
            }
            else
            {
                for(i=0;i<GetTinta();i++)
                {
                    dibujar += "*";
                }
              
            }
            return devolver;
            /*bool devolver = false;
            int i;
            string dato = "";
            if(this._tinta - gasto >=0)
            {
                this._tinta = (short)(this._tinta - gasto);
                for (i = 0; i < gasto; i++)
                {
                    dato += "*";
                }
                dibujar = dato;
                devolver = true;
            }
            else
            {
                for(i=0;i<GetTinta();i++)
                {
                    dato += "*";
                }
                dibujar = dato;
            }
            return devolver;*/
            
        }
        public void  Recargar()
        {
            this._tinta = cantidadMaxima;
        }
        private void SetTinta(short tinta)
        {
            short aux;
            aux = this.GetTinta();

            if (aux + tinta >= 0 && aux + tinta <= 100)
            {
                this._tinta = (short)(aux + tinta);
            }
        }

    }
}
