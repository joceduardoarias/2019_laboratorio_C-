using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        //PROPIEDADES
        public float GananciasPorLocal
        {
            get { return CalcularGanacia(Ellamada.Local); }
        }
        public float GananciasPorProvincia
        {
            get { return CalcularGanacia(Ellamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanacia(Ellamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        //CONSTRUCTOR
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        //METODOS
        private float CalcularGanacia(Ellamada tipoLlamada)
        {
            float acumulador = 0;
            if (tipoLlamada == Ellamada.Local)
            {
                for (int i = 0; i < this.listaDeLlamadas.Count; i++)
                {
                    if (this.listaDeLlamadas[i] is Local)
                    {
                        acumulador += ((Local)this.listaDeLlamadas[i]).CostoLLamada;
                    }
                }
            }
            if (tipoLlamada == Ellamada.Provincial)
            {
                for (int i = 0; i < this.listaDeLlamadas.Count; i++)
                {
                    if (this.listaDeLlamadas[i] is Provincial)
                    {
                        acumulador += ((Provincial)this.listaDeLlamadas[i]).CostoLLamada;
                    }
                }
            }
            if (tipoLlamada == Ellamada.Todas)
            {
                for (int i = 0; i < this.listaDeLlamadas.Count; i++)
                {
                        if (this.listaDeLlamadas[i] is Local && tipoLlamada == Ellamada.Todas)
                        {
                            acumulador += ((Local)this.listaDeLlamadas[i]).CostoLLamada;
                        }
                        else
                        {
                            if (this.listaDeLlamadas[i] is Provincial && tipoLlamada == Ellamada.Todas)
                            {
                                acumulador += ((Provincial)this.listaDeLlamadas[i]).CostoLLamada;
                            }
                        }
                }
            }
            return acumulador;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon social: " + this.razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancia Provincial " + this.GananciasPorProvincia);
            //como funciona con el foreach
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private  void AgregarLlmada(Llamada l)
        {
            this.Llamadas.Add(l);
        }
        public static bool operator ==(Centralita c,Llamada l)
        {
            bool flag = false;
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if(item==l)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }
        public static Centralita operator +(Centralita c, Llamada l)
        {
            
            
                if (c != l)
                {
                    c.AgregarLlmada(l);
                }
            else
            {
                throw new CentralitaException("la llamada ya esta en sistema!", "M", "C",null);
            }
            return c;
        }
    }
}
