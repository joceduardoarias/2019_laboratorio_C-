using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //asociar el evento click del boton label al 
            this.lblEtiqueta.Click += new EventHandler(Manejadora.Manejador);
            this.txtCuadroTexto.Click += new EventHandler(Manejadora.Manejador);
            this.MostrarMensaje.Click += new EventHandler(Manejadora.Manejador);
            Manejadora manejadora = new Manejadora();
            this.lblEtiqueta.Click += new EventHandler(manejadora.ManejadorInstancia);
            this.txtCuadroTexto.Click += new EventHandler(manejadora.ManejadorInstancia);
            this.MostrarMensaje.Click += new EventHandler(manejadora.ManejadorInstancia);
        }
        //Tdos los metodos siguientes son manejadores de eventos
        
        // objeto = button
        private void MostrarMensaje_Click(object sender, EventArgs e)//Evento = click
        {
            MessageBox.Show("Mensaje adentro del boton click");
            //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);//Delegado
            //this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);//Delegado
        }
        // objeto = label
        private void lblEtiqueta_Click(object sender, EventArgs e)//Evento = click
        {
            MessageBox.Show("Mensaje adentro del label");
            //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);//Delegado
        }
        // objeto = texbox
        private void txtCuadroTexto_Click(object sender, EventArgs e)//Evento = click
        {
            MessageBox.Show("Mensaje adentro del TexBox");
        }
        //todos tienen la misma firma y los mismos parametros
        
    }
}
