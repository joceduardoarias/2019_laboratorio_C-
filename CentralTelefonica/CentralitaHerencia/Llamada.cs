using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        //PROPIEDADES
        public abstract float CostoLLamada { get; }
        public float Duracion { get { return _duracion; } }
        public string NroDestino { get { return _nroDestino; } }
        public string NroOrigen { get { return _nroOrigen; } }
        //CONSTRUCTOR
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        //METODOS
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.Duracion);
            sb.AppendLine("Origen: " + this.NroOrigen);
            sb.AppendLine("Destino: " + this.NroDestino);
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = -1;
            if (llamada1._duracion > llamada2._duracion)
            {
                retorno = 1;
            }
            return retorno;
        }
        public static bool operator ==(Llamada l1,Llamada l2)
        {
            bool flag = false;
            if(l1.Equals(l2))
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
