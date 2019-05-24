using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas
        {
            get
            {if (this._cantidadDePaginas == 0)
                    this._cantidadDePaginas =Convert.ToInt32( _generadorDePaginas);
                return this._cantidadDePaginas;
            }
        }
        #region CONSTRUCTOR
        static Libro()
        {
            _generadorDePaginas = new Random();
            _generadorDePaginas.Next(10, 580);
        }
        public Libro(string titulo,Autor autor,float precio)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = autor;


        }
        public Libro(float precio,string titulo,string nombre,string apellido):this(titulo,new Autor(nombre,apellido),precio)
        {
            //this._precio = precio;
            //this._titulo = titulo;
        }
        #endregion

        #region METODOS
        protected static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE:" + l._titulo);
            sb.AppendLine("AUTOR:" + l._autor);
            sb.AppendLine("CANTIDAD DE PAGINAS:" + l._cantidadDePaginas);
            sb.AppendLine("PRECIO:" + l._precio);
            return sb.ToString();
        }
        public static explicit operator string(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE:" + l._titulo);
            sb.AppendLine("AUTOR:" + l._autor);
            sb.AppendLine("CANTIDAD DE PAGINAS:" + l._cantidadDePaginas);
            sb.AppendLine("PRECIO:" + l._precio);
            return sb.ToString();
        }
        public static bool operator ==(Libro libroUno,Libro libroDos)
        {
            bool flag = false;

            if(libroUno._titulo == libroDos._titulo && libroUno._autor == libroDos._autor)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Libro libroUno, Libro libroDos)
        {
            return !(libroUno == libroDos);
        }
        #endregion
    }
}
