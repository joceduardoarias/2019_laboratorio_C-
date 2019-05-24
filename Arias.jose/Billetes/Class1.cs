using System;

namespace Billetes
{
    #region Dolar 
    public class Dolar
    {
        private double _cantidad;
        private static float cotizResoectoDolar;
        /// <summary>
        /// constructor
        /// </summary>
        private Dolar():this(0,0)
        {

        }
        /// <summary>
        /// sobrecarga costructor inicializa el atributo cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Dolar(Double cantidad) :this(cantidad,0)
        {

        }
        /// <summary>
        /// Constructor inicializa los atributos de nuestra clase
        /// </summary>
        /// <param name="cantidad">cantidad de dolares</param>
        /// <param name="cotizRespectoDolar">cotizacion de la moneda</param>
        public Dolar(Double cantidad, float cotizRespectoDolar)
        {            
            this._cantidad = cantidad;
            Dolar.cotizResoectoDolar = cotizRespectoDolar;
            
        }
        /// <summary>
        /// retorna la cantidad de dinero disponible
        /// </summary>
        /// <returns>_cantidad</returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }
        /// <summary>
        /// retorna la cotizacion de la moneda en dolar
        /// </summary>
        /// <returns>cotizResoectoDolar</returns>
        public static float GetCotizacion()
        {
            return Dolar.cotizResoectoDolar;
        }
        /// <summary>
        /// Explicit. convierte una cantidad de dolares a su equivalencia en euros
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((1 / 1.16) * d._cantidad);
        }
        /// <summary>
        /// Explicit. convierte una cantidad de dolares a su equivalencia en pesos
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos((1 / 38.33) * d._cantidad);
        }
        /// <summary>
        /// Implicit. convierte un tipo de dato double a tipo de dato Dolar
        /// </summary>
        /// <param name="d">cantidad de dinero</param>
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        /// <summary>
        /// Igualdad (Dolar, Euro). Retorna, true, cuando la cantidad de 
        /// dolares es equivalente a la cantidad de euros.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d,Euro e)
        {
            bool retorno = false;
            if(((Dolar)e).GetCantidad() == d._cantidad) //pasa la catidad de euros a dolar para verificar que son iguales
            {
                retorno = true;
            }
                return retorno;
            //el error que salta es porque hasta ahora no he desarrollado emtodo Dolar(Euro)
        }
        /// <summary>
        /// Diferente (Dolar, Euro). Retorna, true, cuando la cantidad de 
        /// dolares es diferente a la cantidad de euros.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>retorno, true, si la cantidad de dolares es iugual a la cantidad euros convertidos a dolares</returns>
        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }
        /// <summary>
        /// Igualdad (Dolar, Pesos). Retorna, true, cuando la cantidad de 
        /// dolares es equivalente a la cantidad de pesos.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns>retorna, true, si la cantidad dolares es equivalente a la cantidad de pesos</returns>
        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;
            if(d.GetCantidad()== ((Dolar)p).GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferente (Dolar,Peso). Retorna, true, cuando la cantidad de 
        /// dolares es diferente a la cantidad de pesos.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns>retorna ,true, si la cantidad de dolares es distinta a la cantidad de euros</returns>
        public static bool operator != (Dolar d, Pesos p)
        {
            return !(d == p);
        }
        /// <summary>
        /// Igualdad (Dolar,Dolar). Retorna, true, cuando la cantidad de 
        /// dolares d1 es equivalte a la cantidad de dolares d2.
        /// </summary>
        /// <param name="d1">cantidad en dolares</param>
        /// <param name="d2">cantidad en dolares</param>
        /// <returns>retorna true si hay equivalencia de cantidades</returns>
        public static bool operator == (Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if(d1._cantidad == d2._cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferente (Dolar,Dolar). Retorna, true, cuando la cantidad de 
        /// dolares d1 es equivalte a la cantidad de dolares d2.
        /// </summary>
        /// <param name="d1">cantidad en dolares</param>
        /// <param name="d2">cantidad en dolares</param>
        /// <returns>retorna true si no hay  equivalencia de cantidades</returns>
        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1._cantidad == d2._cantidad);
        }
        /// <summary>
        /// Suma (Dolar,Euro). Retorna la cantidad en dolares suma de un tipo Dolar con un tipo Euro.
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        /// <param name="e">cantidad de euros</param>
        /// <returns>retorna la cantidad de dolares resultado de la suma</returns>
        public static Dolar operator + (Dolar d, Euro e)
        {
            return new Dolar( d._cantidad + (((Dolar)e).GetCantidad()));
        }
        /// <summary>
        /// Resta (Dolar,Euro). Retorna la cantidad en dolares restada de un tipo Dolar con un tipo Euro.
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        /// <param name="e">cantidad de euros</param>
        /// <returns>retorna la cantidad de dolares resultado de la resta</returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar( d.GetCantidad() - e.GetCantidad());
        }
        /// <summary>
        /// Suma (Dolar,Pesos). Retorna la cantidad en dolares suma de un tipo Dolar con un tipo Pesos.
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        /// <param name="p">cantidad de euros</param>
        /// <returns>retorna la cantidad de dolares resultado de la suma</returns>
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d._cantidad + ((Dolar)p).GetCantidad();
        }
        /// <summary>
        /// Resta (Dolar,Pesos). Retorna la cantidad en dolares restada de un tipo Dolar con un tipo Pesos.
        /// </summary>
        /// <param name="d">cantidad de dolares</param>
        /// <param name="p">cantidad de euros</param>
        /// <returns>retorna la cantidad de dolares resultado de la resta</returns>
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d._cantidad - ((Dolar)p).GetCantidad();
        }
    }
    #endregion
    #region Euro
    public class Euro
    {
        private double _cantidad;
        private static float _cotizRespectoDolar;
        private Euro() : this(0, (float)1.16)
        {

        }
        /// <summary>
        /// sobrecarga costructor inicializa el atributo cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Euro(double cantidad) : this(cantidad, 0)
        {

        }
        /// <summary>
        /// Constructor inicializa los atributos de nuestra clase
        /// </summary>
        /// <param name="cantidad">cantidad de dolares</param>
        /// <param name="cotizRespectoDolar">cotizacion de la moneda</param>
        public Euro(Double cantidad, float cotizRespectoDolar)
        {
            this._cantidad = cantidad;
            Euro._cotizRespectoDolar = cotizRespectoDolar;
        }
        /// <summary>
        /// GetCantidad. Retorna la cantida de euros
        /// </summary>
        /// <returns>cantidad de euros</returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }
        /// <summary>
        /// GetCotiza. Retorna la cotizacion de del Euros con respecto al dolar
        /// </summary>
        /// <returns></returns>
        public static float GetCotiza()
        {
            return Euro._cotizRespectoDolar;
        }
        /// <summary>
        /// Conversion explicita de tipo de dato Euro a Dolar
        /// </summary>
        /// <param name="e">catidad de euros</param>
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((1 / 1.16) * e._cantidad);
        }
        /// <summary>
        /// Conversion explicita de tipo de dato Euro a Pesos
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(((Dolar)e).GetCantidad()*38.33,Euro.GetCotiza());
        }
        /// <summary>
        /// Conversion de double a Euro.
        /// </summary>
        /// <param name="cantidad"></param>
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad * Euro.GetCotiza(), Euro.GetCotiza());
        }
        /// <summary>
        /// Igualdad (Euro,Dolar). Retorna, true, cuando la cantidad de 
        /// dolares d es equivalte a la cantidad de euros e.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e,Dolar d)
        {
            bool retorno = false;
            if( ((Dolar) e).GetCantidad() == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferencia (Euro,Dolar). Retorna, true, cuando la cantidad de 
        /// dolares d no es equivalte a la cantidad de euros e.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns>retorna true si no son equivalentes</returns>
        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }
        /// <summary>
        /// Igualdad (Euro,Pesos). Retorna, true, cuando la cantidad de 
        /// pesos d es equivalte a la cantidad de euros e. 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>retono</returns>
        public static bool operator == (Euro e, Pesos p)
        {
            bool retorno = false;
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferencia (Euro,Pesos). Retorna, true, cuando la cantidad de 
        /// pesos p no es equivalte a la cantidad de euros e. 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator != (Euro e, Pesos p)
        {
            return !(e == p);
        }
        /// <summary>
        /// Igualdad (Euro,Euro). Retorna, true, cuando la cantidad de 
        /// euros e1 es equivalte a la cantidad de euros e2.  
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>retrono</returns>
        public static bool operator == (Euro e1,Euro e2)
        {
            bool retorno = false;
            if(e1.GetCantidad() == e2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Diferencia (Euro,Euro). Retorna, true, cuando la cantidad de 
        /// euros e1 no es equivalte a la cantidad de euros e2.  
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>retrono</returns>
        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(((Euro)d).GetCantidad(),Euro._cotizRespectoDolar);
        }
    }
    #endregion
    #region Pesos
    public class Pesos
    {
        private double _cantidad;
        private float _cotizRespectoDolar;
        private Pesos() : this(0, 0)
        {

        }
        /// <summary>
        /// sobrecarga costructor inicializa el atributo cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Pesos(double cantidad) : this(cantidad, 0)
        {

        }
        /// <summary>
        /// Constructor inicializa los atributos de nuestra clase
        /// </summary>
        /// <param name="cantidad">cantidad de dolares</param>
        /// <param name="cotizRespectoDolar">cotizacion de la moneda</param>
        public Pesos(Double cantidad, float cotizRespectoDolar)
        {
            this._cotizRespectoDolar = cotizRespectoDolar;
            this._cantidad = cantidad;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        public static implicit operator Pesos(double cantidad)
        {
            return  new Pesos(cantidad);
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad());
        }
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.GetCantidad());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        /// 
        public static bool operator ==(Pesos p, Dolar d)
        {
            bool respuesta = false;
            if (p.GetCantidad() == ((Dolar)d).GetCantidad())// paso los dolares a pesos para que sea equivalente
            {
                respuesta = true;
            }
            return respuesta;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static  bool  operator == (Pesos p, Euro e)
        {
            bool retorno = false;
            if(p.GetCantidad() == e.GetCantidad())
            {
                retorno = true;
            }
           return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pesos p1,Pesos p2)
        {
            bool retorno = false;
            if(p1.GetCantidad()==p2.GetCantidad())
            {
                retorno = true;
            }
           return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
    }
    #endregion
}
