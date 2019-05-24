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
namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            DateTime fecha;
            int valor;
            
            valor =int.Parse( this.textBox1.Text);
            cadena = this.textBox3.Text;
            fecha =DateTime.Parse( this.textBox2.Text);

            Cosa obj;

            obj = new Cosa(valor, fecha, cadena);

            MessageBox.Show(obj.Mostrar());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";   
        }
    }
}
