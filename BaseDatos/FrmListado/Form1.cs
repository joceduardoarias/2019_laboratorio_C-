using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace FrmListado
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;
        private DataTable table;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personas = accesoDatos.TraerTodos();//cargo la lista
            table = accesoDatos.TablaPersona();//cargo la tabla
            dataGridView1.DataSource = personas; //le paso la lista de personas cargadas
        }
    }
}
