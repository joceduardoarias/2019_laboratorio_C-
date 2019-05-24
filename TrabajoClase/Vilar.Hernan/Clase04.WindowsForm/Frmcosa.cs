using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04;

namespace Clase04.WindowsForm
{
    public partial class Frmcosa : Form
    {
        public Frmcosa()
        {
            //constructor
            InitializeComponent();
           

        }

        private void Frmcosa_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mundo");
            DateTime fecha;
            int entero = 0;
            string cadena = "";

            cadena = this.textBox3.Text;
            int.TryParse(this.textBox2.Text, out entero);
            DateTime.TryParse(this.textBox1.Text, out fecha);
           
            

            Cosa ob1 = new Cosa(entero,fecha,cadena);
            MessageBox.Show(ob1.Mostrar());
            
            //this.BackColor = Color.Blue; // te cambia el color del fondo en tiempo de ejecucion
            //this.Text = "dato"; // cambia el titulo del window form
            //this.button1.Text = "cosa bonita"; //te cambia el nombre del boton en tiempo de ejecucion
            //MessageBox.Show(ob1.Mostrar());
             // agregar al formulario 3 tipos de elementos de tipo textbox y cuando apreto click muestro   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
