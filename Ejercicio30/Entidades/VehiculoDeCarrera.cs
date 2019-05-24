using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        
        #region PROPIEDAD
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                
                this.vueltasRestantes = value
;
            }
        }
        public string Escuderia
        {
            get {return this.escuderia; }
            set { this.escuderia = value; }
        }
        public short Numero
        {
            get {return this.numero; }
            set { this.numero = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }
        
        #endregion

        #region METODOS
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Numero: " + this.numero);
            sb.AppendLine("CantidadCombustible: " + this.cantidadCombustible);
            sb.AppendLine("VueltasRestantes: " + this.vueltasRestantes);
            return sb.ToString();
        }
        public static bool operator ==(VehiculoDeCarrera v1,VehiculoDeCarrera v2)
        {
            bool flag = false;
            if(v1.escuderia==v2.escuderia&&v1.numero==v2.numero)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
               #endregion
    }
}
