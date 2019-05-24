using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
   public class Provincial:Llamada
    {
        protected Efranja franjaHoraria;
        //PROPIEDAD
        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto() ;
            }
        }

        //CONSTRUCTORES
        public Provincial(Efranja franjaHoraria,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {

        }
        public Provincial(string origen,string destino,float duracion,Efranja franjaHoraria):base(duracion,destino,origen)
        {
            this.franjaHoraria = franjaHoraria;
        }
        public string MostrarProvincial()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja Horaria: " + this.franjaHoraria);
            sb.AppendLine("Costa de la llamada: " + this.CostoLLamada);
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float retorno = 0;
            if(this.franjaHoraria == Efranja.Franja_1)
            {
                retorno = (float)0.99 * this._duracion;
            }
            if (this.franjaHoraria == Efranja.Franja_2)
            {
                retorno = (float)1.25 * this._duracion;
            }
            if (this.franjaHoraria == Efranja.Franja_3)
            {
                retorno = (float)0.66 * this._duracion;
            }
            return retorno;
        }
        public override bool Equals(object obj)
        {
            bool flag = false;
            if(obj is Provincial)
            {
                flag = true;
            }
            return flag;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
