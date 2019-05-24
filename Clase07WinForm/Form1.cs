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
    public partial class Form1 : Form
    {
         Paleta paleta;
        public Form1()
        {
            InitializeComponent();
            this.paleta = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hacer visible el otro formulario
            FmTemperas fmt;
            fmt = new FmTemperas();
            fmt.ShowDialog();
            
            this.paleta += fmt.MiTempera;

            foreach (Tempera c in paleta.MyTemperas)
            {
                listBox1.Items.Add(Tempera.Mostrar(c));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
