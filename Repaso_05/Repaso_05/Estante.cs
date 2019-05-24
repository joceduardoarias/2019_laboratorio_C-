using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_05
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        /// <summary>
        /// CONSTRUCTOR
        /// El constructor de instancia privado será el único que inicializará el array
        /// </summary>
        /// <param name="capacidad"> capacidad del array </param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        /// <summary>
        /// La sobrecarga pública del constructor inicializará la ubicación del estante,
        /// recibiendo como parámetro capacidad y ubicación.
        /// </summary>
        /// <param name="capacidad">capacidad del aray</param>
        /// <param name="ubicacion">ubicacion del elemento denro del array</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            //Este metodo llama al metodo privado para que este le pase la capacidad.
            this.ubicacionEstante = ubicacion;
        }
        /// <summary>
        /// El método público GetProductos, retornará el array de productos.
        /// </summary>
        /// <returns>retornará el array de productos</returns>
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string cadena = " Informacio de productos Disponibles \n";
            
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(object.ReferenceEquals(e.productos[i], null)))
                {
                    cadena += "\n"+ Producto.MostrarProducto(e.productos[i]);
                }
                    
            }
            return cadena;
        }

        //****************************
        //*SOBRE CARGAR DE OPERADORES*
        //****************************

        /// <summary>
        /// Igualdad, retornará true, si es que el producto ya se encuentra 
        /// en el estante, false, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            int i = 0;
            foreach (Producto producto in e.productos)
            {
                if (!(object.ReferenceEquals(e.productos[i], null)))
                {
                    if (e.productos[i] == p)
                    {
                        retorno = true;
                    }
                }
                i++;
            }
            return retorno;
        }
        /// <summary>
        /// Diferente, retornará true, si es que el producto no se encuentra 
        /// en el estante, false, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        /// <summary>
        /// Adición, retornará true y agregará el producto si el estante posee capacidad de
        /// almacenar al menos un producto más y 
        ///dicho producto no se encuentra en él; false, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if ((object.ReferenceEquals(e.productos[i], null))&& e != p)//tenia un error antes que era que el array[i] 
                    {                                                           //deberia ser igual a null para que este identificara
                        e.productos[i] = p;                                     //que habia un lugar libre y cuando no encuentra ningun
                        retorno = true;                                         //el array esta lleno.
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado.
        /// </summary>
        /// <param name="e"> objeto tipo estante</param>
        /// <param name="p">objeto tipo p</param>
        /// <returns>bool</returns>
        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = false;
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (!(object.ReferenceEquals(e.productos[i], null)))
                    {
                        e.productos[i] = null;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}
