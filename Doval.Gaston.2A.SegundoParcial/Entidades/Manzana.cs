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
    public class Manzana : Fruta, ISerializable
    {
        public string distribuidora;
        private string rutarchivo;

        public Manzana(float peso, ConsoleColor color, string dist)
            : base(peso, color)
        {
            this.distribuidora = dist;
        }

        public Manzana()
        { }

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo { get{return "Manzana";} }

        protected override string FrutaToString()
        {
            string resp = "";
            resp += base.FrutaToString() + " " + this.Tipo + " " + this.distribuidora;
            return resp;
        }

        public override string ToString()
        {
            string r = "";
            r += this.FrutaToString();
            return r;
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

        public bool SerializarXML()
        {
            bool resp = true;
            try
            {
                XmlTextWriter guardar = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(Manzana));
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

        public bool Deserializar()
        {
            bool resp = true;
            Manzana man = new Manzana(this._peso, this._color, this.distribuidora);
            try
            {
                XmlSerializer serializo = new XmlSerializer(typeof(Manzana));
                XmlTextReader leo = new XmlTextReader(this.RutaArchivo);
                man = (Manzana)serializo.Deserialize(leo);
                leo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resp = false;
            }
            return resp;
        }
    }
}
