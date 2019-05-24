using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_05
{
  public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //CONSTRUCTOR
        public Producto():this(null,null,0)
        {

        }
        public Producto(string codigoDeBarras):this(codigoDeBarras,null,0)
        {

        }
        public Producto(string codigoDeBarras,string marca):this(codigoDeBarras,marca,0)
        {

        }
        public Producto(string marca ,string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        //METODOS
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            string retorno = " ";
            retorno += " | "+p.GetMarca() + "  " + p.GetPrecio().ToString() + "  " + p.codigoDeBarra;
            return retorno;
        }
        /// <summary>
        /// Explícito. Realizará la conversión de un objeto Producto a string. 
        /// Sólo retornará el atributo codigoDeBarras del producto.
        /// </summary>
        /// <param name="p"> es un objeto de tipo Producto </param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        /// <summary>
        /// Igualdad (Producto, Producto). Retornará true, si las marcas y
        /// códigos de barras son iguales, false, caso contrario.
        /// </summary>
        /// <param name="p1">es un objeto de tipo Producto</param>
        /// <param name="p2">es un objeto de tipo Producto</param>
        /// <returns>bool</returns>
        public static bool operator == (Producto p1,Producto p2 )
        {
            bool retorno = false;
            if(p1.codigoDeBarra ==p2.codigoDeBarra && p1.marca == p2.marca )
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferente (Producto, Producto). Retornará true, si las marcas y
        /// códigos de barras son diferentes, false, caso contrario.
        /// </summary>
        /// <param name="p1">es un objeto de tipo Producto</param>
        /// <param name="p2">es un objeto de tipo Producto</param>
        /// <returns>bool</returns>
        public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        /// <summary>
        /// Igualdad (Producto, string). Retornará true, si la marca del producto
        /// coincide con la cadena pasada por parámetro, false, caso contrario.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="marca"></param>
        /// <returns>bool</returns>
        public static bool operator == (Producto p1,string marca)
        {
            bool retorno = false;
            if(p1.marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferente (Producto, string). Retornará true, si la marca del producto no
        /// coincide con la cadena pasada por parámetro, false, caso contrario.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="marca"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}
