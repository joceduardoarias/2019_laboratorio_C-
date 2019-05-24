using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
   public class Local:Llamada
    {
        protected float costo;
        public Local (Llamada  llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }
        public Local(string origen, float duracion, string destino,float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        //PROPIEDAD
        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //METODOS
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Mostrar());
            sb.AppendLine("Costo llamada: " + this.CostoLLamada);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if(  obj is Local)
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

