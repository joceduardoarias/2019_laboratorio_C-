using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06;

namespace Clase07
{
    public partial class frmTempera : Form
    {
        
        public frmTempera()
        {
            InitializeComponent();
            foreach(ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                comboBox1.Items.Add(item);
            }
            
        }
        public frmTempera(Tempera temp) : this()
        {
            //this._miTempera = temp;
            comboBox1.SelectedItem = temp.MyColor;
            textBox1.Text = temp.MyMarca;
            textBox2.Text = ((sbyte)temp).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {
            //Enum.GetValues(typeof(ConsoleColor)); // hace que detecte todas las enumeraciones y me geera unacoleccion
            //con esos valores, y lo pongo en un forcheach.
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sbyte dato;
            sbyte.TryParse(textBox2.Text, out dato);
            Tempera nuevaTempera = new Tempera((ConsoleColor)comboBox1.SelectedItem, textBox1.Text, dato);
            this._miTempera = nuevaTempera;
            //MessageBox.Show(Tempera.Mostrar(nuevaTempera));
            this.DialogResult = DialogResult.OK;
            
        }
        public void ObtenerString(string data)
        {
            
            string[] separadas;
            separadas = data.Split('-');
            this.textBox1.Text = separadas[1];
            this.textBox2.Text = separadas[2];
            //this.comboBox1.SelectedItem = data[0];
            // comboBox1. =  comboBox1.SelectedIndex = 2;
            //comboBox1.SelectedValue = separadas[0];
            //Tempera nuevaTempera = new Tempera((ConsoleColor)Enum.Parse(typeof(ConsoleColor)

        }

        private Tempera _miTempera;

        public Tempera MyTempera
        {
            get { return _miTempera; }
            //set { _miTempera = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
        */
        public void verificar(int numero)
        {
            if (numero == 1)
            {
                this.button3.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
