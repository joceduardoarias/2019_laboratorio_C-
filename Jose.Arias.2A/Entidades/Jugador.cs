using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public  class Jugador:Persona
    {
        private float altura;
        private float peso;
        private EPosicion posicion;

        #region PROPIEDADES
        public float Altura { get {return this.altura; } }
        public float Peso { get {return this.peso; } }
        public EPosicion Posicion { get { return this.posicion; } }
        #endregion

        #region CONSTRUCTOR
        public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,EPosicion posicion):base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        #endregion

        #region METODOS
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Altura:"+this.altura);
            sb.AppendLine("Peso:" + this.peso);
            sb.AppendLine("Posicion:" + this.posicion);
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool flag = false;
            if(this.Edad < 40 && this.EstadoFisico())
            {
                flag = true;
            }
            return flag;
        }
        public bool EstadoFisico()
        {
            bool flag=false;
            double IMC;
            IMC = this.peso / Math.Pow(this.altura, 2);
            if(IMC >18.5 &IMC <=25)
            { flag = true; }
            return flag;
        }
        #endregion
    }
}
