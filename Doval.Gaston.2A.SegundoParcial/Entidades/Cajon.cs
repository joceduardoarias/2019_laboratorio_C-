using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public delegate void CajonDelegado(string path, DateTime fecha, float total);

    public class Cajon<T> : ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;
        public event CajonDelegado EventoPrecio;
        private string rutarchivo;

        public Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(int capacidad, float precio)
            : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public List<T> Frutas { get { return this._frutas; } }

        public override string ToString()
        {
            string r = "";
            r += "Capacidad: " + Convert.ToString(this._capacidad) + " Cantidad frutas: " + Convert.ToString(this._frutas.Count()) + " Precio total: " + Convert.ToString(this._precioUnitario);
            foreach (T f in this._frutas)
            {
                r += "\n" + f.ToString();
            }
            return r;
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T f)
        {
            try
            {
                if (cajon._frutas.Count() == cajon._capacidad)
                    throw new CajonLlenoExcepcion("El cajon no admite mas frutas");
                else
                    cajon._frutas.Add(f);
                return cajon;
            }
            catch (CajonLlenoExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
            return cajon;
        }

        public float PrecioTotal {
            get
            {
                this._precioUnitario = this._precioUnitario * this.Frutas.Count;
                if (this._precioUnitario > 25)
                {
                    this.EventoPrecio("prueba.txt", DateTime.Now, this._precioUnitario);
                    return this._precioUnitario;
                }
                else
                    return this._precioUnitario;
            }
        }


        public string RutaArchivo
        {
            get
            {
                return this.rutarchivo;
            }
            set
            {
                this.rutarchivo = value;
            }
        }

        public bool Deserializar()
        {
            bool resp = true;
            T a = default(T);
            try
            {
                XmlSerializer serializo = new XmlSerializer(typeof(Cajon<T>));
                XmlTextReader leo = new XmlTextReader(this.RutaArchivo);
                a = (T)serializo.Deserialize(leo);
                leo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resp = false;
            }
            return resp;
        }

        public bool SerializarXML()
        {
            bool resp = true;
            try
            {
                XmlTextWriter guardar = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(Cajon<T>));
                serializa.Serialize(guardar, this);
                guardar.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resp = false;
            }
            return resp;
        }

        public void ImprimirTxt(string path, DateTime fecha, float total)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(path);
                archivo.WriteLine(Convert.ToString(fecha) + " " + Convert.ToString(total));
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
