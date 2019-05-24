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
    public partial class FmPaletas : Form
    {

        Paleta paleta;
        public FmPaletas()
        {
            InitializeComponent();
            this.paleta = 5;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //hacer visible el otro formulario
            FmTemperas fmt;
            fmt = new FmTemperas();
            fmt.ShowDialog();

            this.paleta += fmt.MiTempera;

            foreach (Tempera c in paleta.MyTempera)
            {
                listBox1.Items.Add(Tempera.Mostrar(c));
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
