using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesLast;
using System.IO;
namespace Frm
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            foreach (TipoManejador item in Enum.GetValues(typeof(TipoManejador)))
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoSueldoArg empleado = new EmpleadoSueldoArg();
            Form1 form1 = new Form1();
            
            empleado.Legajo =int.Parse(txtLegajo.Text);
            empleado.Nombre = txtNombre.Text;
            empleado.Sueldo = float.Parse(txtSueldo.Text);

            switch ((TipoManejador)comboBox1.SelectedItem)
            {
                case TipoManejador.LimiteSueldo:
                    empleado.LimiteSueldo += new DelSueldo(EmpleadoMejorado_LimiteSueldo);
                    break;
                case TipoManejador.Log:
                    empleado.LimiteSueldo += new DelSueldo(EmpleadoMejorado_Log_LimiteSueldo);
                    break;
                case TipoManejador.Ambos:
                    empleado.LimiteSueldo += new DelSueldo(EmpleadoMejorado_LimiteSueldo);
                    empleado.LimiteSueldo += new DelSueldo(EmpleadoMejorado_Log_LimiteSueldo);
                    break;
                default:
                    break;
            }


        }
        public static void EmpleadoMejorado_LimiteSueldo(EmpleadoMejorado empleado, EmpleadoSueldoArg sueldo)//manejador de evento con la misma firma del evento
        {
            MessageBox.Show(DateTime.Now.ToString() + empleado.Nombre + empleado.Legajo + sueldo.Sueldo.ToString());
        }
        public void EmpleadoMejorado_Log_LimiteSueldo(EmpleadoMejorado empleado, EmpleadoSueldoArg sueldo)
        {
            StreamWriter text = new StreamWriter("guardarlog");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString() + empleado.Nombre + empleado.Legajo + sueldo.Sueldo.ToString());
            text.Write(sb.ToString());
            text.Close();
        }

      
    }
}
