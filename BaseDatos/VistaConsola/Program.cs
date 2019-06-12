using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data;
namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {   
            //List<Persona> lista = new List<Persona>();
            //Persona persona = new Persona(52, "evo", "morales", 100);
            AccesoDatos datos = new AccesoDatos();
            //// datos.AgregarPersona(persona);
            //datos.ModificarPersona(persona);
            //lista = datos.TraerTodos();
            //foreach (Persona item in lista)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //uso del metodo datatable
            DataTable table = new DataTable("Personas");
            // table = datos.TablaPersona();
            //foreach (DataRow item in table.Rows)
            //{
            //    Console.WriteLine(item[0].ToString(), item["id"].ToString(),item["nombre"].ToString(), item["apellido"], item["edad"].ToString());
            //}

            //table.WriteXml 
            table.WriteXmlSchema("persona_esquema.xml"); //serializar
            table.WriteXml("personas_datos.xml");//serializar

            //table.ReadXmlSchema("persona_esquema.xml");//deserealizar
            //table.ReadXml("personas_datos.xml");//deserealizar
            Console.ReadKey();
        }
    }
}
