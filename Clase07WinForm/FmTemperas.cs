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
namespace Clase07WinForm
{
    public partial class FmTemperas : Form
    {
        public FmTemperas()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FmTemperas_Load(object sender, EventArgs e)
        {
            //Enum.GetValues(typeof(ConsoleColor));
            // le estoy pasando un tipo de dato consolecolor. Esta sentencia me devuelve una coleccion
            // coleccion que recorro con foreach, todos los colores de la coleccion se guardan en la variable c.
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);// en sentencia los valores de la colecccion se van agregando al combox1
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturar todos los datos, para esto se debe instanciar un  objeto. 
            Tempera tempera;
            tempera = new Tempera((ConsoleColor)comboBox1.SelectedItem, textBox1.Text, sbyte.Parse(textBox2.Text));
            //mostar los datos capturados
            //MessageBox.Show(Tempera.Mostrar(tempera));
            this._miTempera = tempera;
        }
        //comparte entre la clases form
        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get { return _miTempera; }
        }

        

    }
}
