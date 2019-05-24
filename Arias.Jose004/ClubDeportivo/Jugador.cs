using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
   public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get { return this.altura; }
        }
        public float Peso
        {
            get {return this.peso; } 
        }
        public Posicion Posicion
        {
            get {return this.posicion; }
        }

        //METODOS

        public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad <= 40)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            double IMC;
            IMC = this.Peso / Math.Pow(this.Altura, 2);
            if(IMC >= 18.5 && IMC <=25)
            {
                retorno = true;
            }
            return retorno;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Altura:" + this.Altura);
            sb.AppendLine("Peso:" + this.Peso);
            sb.AppendLine("Posicion:" + this.Posicion);
            return sb.ToString();
        }
    }
}
