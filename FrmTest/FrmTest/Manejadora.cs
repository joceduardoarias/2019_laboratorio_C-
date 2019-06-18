using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FrmTest
{
   public class Manejadora
    {
        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje dentro del Manejador estatico");
            if(sender is TextBox)
            {
                MessageBox.Show("Mensaje dentro del Manejador estatico y esde tipo texbox");
            }
        }
        public void ManejadorInstancia(object sender, EventArgs e)
        {
            MessageBox.Show("Instancia dentro del Manejador de instancia");
            if (sender is TextBox)
            {
                MessageBox.Show("Mensaje dentro del Manejador de instancia y esde tipo texbox");
            }
        }
        public static void Sumar(int a,int b)
        {
            MessageBox.Show((a + b).ToString());
        }
        public void Restar(int a, int b)
        {
            MessageBox.Show((a - b).ToString());
        }
        public void Multiplicar(int a, int b)
        {
            MessageBox.Show((a * b).ToString());
        }
        public void OtraSuma(MiDelagado d, int a, int b)
        {
            MessageBox.Show((a + b).ToString());
        }
    }
}
