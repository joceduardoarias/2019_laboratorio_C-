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
    public partial class Form1 : Form
    {
        Paleta p1;


        public Form1()
        {
            InitializeComponent();
            this.p1 = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera t1 = new frmTempera();
            t1.verificar(1);
            if (t1.ShowDialog() == DialogResult.OK)
            {
                this.p1 += t1.MyTempera;
                //listBox1.Items.Add(Tempera.Mostrar(t1.MyTempera));// o esto o el foreach previamente limpiarlo con foreach.
            }
            actualizar();
        }
        private  void actualizar()
        {
            listBox1.Items.Clear();

            foreach (Tempera c in p1.MyTemperas)
            {
                if (c != null)
                {
                    listBox1.Items.Add(Tempera.Mostrar(c));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int dato;
            
            dato = listBox1.SelectedIndex;
            frmTempera t1 = new frmTempera(this.p1.MyTemperas[dato]);
            //cadena = listBox1.Items[listBox1.SelectedIndex].ToString();
            //MessageBox.Show(cadena);
            if(t1.ShowDialog() == DialogResult.OK)
            {
                //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                p1 = p1 - t1.MyTempera;
                
                actualizar();


            }
           
            

            //t1.ShowDialog();
            /*
            aux = listBox1.SelectedIndex;
            
            t1.ObtenerString(dato);
       
            if(t1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                p1 = p1 - aux;
               // p1 = p1 - listBox1.Items[listBox1.SelectedIndex];*/
            
           
          

            /*if (t1.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i<p1.cantidadTemperas;i++)
                {
                    if (p1.MyTemperas[i] == t1.MyTempera)
                    {
                        p1.MyTemperas[i] = null;
                    }
                }
              
                
            }
            */
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int dato;
            dato = listBox1.SelectedIndex;
            frmTempera t1 = new frmTempera(this.p1.MyTemperas[dato]);
            if (t1.ShowDialog() == DialogResult.OK)
            {
                //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                p1.MyTemperas[dato] = t1.MyTempera;
                actualizar();
            }
        }
    }
}