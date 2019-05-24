using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;
        #region PROPIEDADES
        public double PrecioDeMauales
        {
            get { return 0; }
        }
        #endregion

        #region CONSTRUCTORES
        public Biblioteca()
        {
            this._libros = new List<Libro>();
        }
        public Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region METODOS
        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Libro item in b._libros)
            {
                if (item is Novela)
                {
                    sb.AppendLine(((Novela)item).Mostrar());
                }
                if (item is Manual)
                {
                    sb.AppendLine(((Manual)item).Mostrar());
                }
            }
            return sb.ToString();
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double acumulador = 0;

            if (tipoLibro == ELibro.Novela)
            {
                foreach (Libro item in this._libros)
                {
                    if (item is Novela)
                    {
                        acumulador = acumulador + ((Novela)item);
                    }
                }
            }
            if (tipoLibro == ELibro.Manual)
            {
                foreach (Libro item in this._libros)
                {
                    if (item is Manual)
                    {
                        acumulador = acumulador + ((Manual)item);
                    }
                }
            }
            if (tipoLibro == ELibro.Ambos)
            {
                foreach (Libro item in this._libros)
                {
                    if (item is Manual)
                    {
                        acumulador = acumulador + ((Manual)item);
                    }
                    if (item is Novela)
                    {
                        acumulador = acumulador + ((Novela)item);
                    }
                }
            }
            return acumulador;
        }
        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);

            return b;
        }
        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool flag = false;
            foreach (Libro item in b._libros)
            {
                if(item == l)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }
        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if(b._libros.Count<b._capacidad && b!=l)
            {
                b._libros.Add(l);
            }
            return b;
        }
        //FALTA TERMINAR ESTE METODO, Y EL QUE ESTA COMENTADO ANTES.
        #endregion
    }
}
