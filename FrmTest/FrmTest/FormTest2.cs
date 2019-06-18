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
    public partial class FormTest2 : Form
    {
        public void Inicializar(object sender, EventArgs e)
        {
            this.btnBoton.Click += new EventHandler(MiManejador);
        }
        public void MiManejador(object sender, EventArgs e)
        {
            string b = ((Control)sender).Name; 
            if ("btnBoton" == b )
            {
                MessageBox.Show(((Control)sender).Name);
                this.btnBoton.Click -= new EventHandler(MiManejador);
                this.btnBoton2.Click += new EventHandler(MiManejador);
            }
            else if("btnBoton2" == b)
            {
                MessageBox.Show(((Control)sender).Name);
                this.btnBoton2.Click -= new EventHandler(MiManejador);
                this.btnBoton3.Click += new EventHandler(MiManejador);
            }
            else if ("btnBoton3" == b)
            {
                MessageBox.Show(((Control)sender).Name);
                this.btnBoton3.Click -= new EventHandler(MiManejador);
                this.btnBoton.Click += new EventHandler(MiManejador);
            }


        }
        public FormTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inicializar);
        }

        private void FormTest2_Load(object sender, EventArgs e)
        {
            
        }

        private void Operar_Click(object sender, EventArgs e)
        {
            Manejadora manejadora = new Manejadora();
            MiDelagado delagado = new MiDelagado(manejadora.Restar);
            MiDelagado delagado2 = new MiDelagado(Manejadora.Sumar);
            MiDelagado miDelagado = (MiDelagado)MiDelagado.Combine(delagado,delagado2);//de esta manera el delegado numero tres tendra disponible los
            //invocar al delegado                                                      // metodos de delegado uno y dos.     
            delagado.Invoke(3, 6);
            MessageBox.Show(miDelagado.Method.ToString());
            MessageBox.Show( delagado.Target.ToString());
            foreach (var item in miDelagado.GetInvocationList())
            {
                MessageBox.Show(item.Method.ToString());
            }
            MiDelagado d4 = (MiDelagado)MiDelagado.Combine(miDelagado, new MiDelagado(manejadora.Multiplicar));
            foreach (var item in d4.GetInvocationList())
            {
                MessageBox.Show(item.Method.ToString());
            }
            
        }
    }
}
