using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        //PROPIEDADES
        public float Altura
        {
            get
            {return this.altura; }
        }
        public float Peso
        {
            get {return this.peso; }
        }
        public Posicion Posicion
        {
            get { return this.posicion; }
        }
        //METODOS
       public Jugador(string nombre, string apellido,int edad,int dni,float peso,float altura,Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Altura:" + this.altura);
            sb.AppendLine("Peso:" + this.peso);
            sb.AppendLine("Posicion" + this.posicion);
            return sb.ToString();
        }
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            double IMC;
            IMC = (this.peso / Math.Pow(this.altura, 2));
            if(IMC >18.5 && IMC<=25)
            {
                retorno = true;
            }
            return retorno;
        }
        public override bool validarAptitu()
        {
            bool retorno = false;
            if(this.Edad < 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
