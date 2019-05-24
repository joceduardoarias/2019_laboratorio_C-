using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo;
namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            DirectorTecnico directorTecnico = new DirectorTecnico(textBox1Nombre.ToString(), textBox2Apellido.ToString(),Convert.ToInt32(numericUpDown1Edad.Value),Convert.ToInt32(numericUpDown2Dni.Value), Convert.ToInt32( numericUpDown3Experiencia.Value));
            MessageBox.Show("DT Creado");
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
