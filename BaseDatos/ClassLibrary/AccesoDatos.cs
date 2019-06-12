using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//libreria siempre debe ir ante de system.Data.SqlClient
using System.Data.SqlClient; //libreria
namespace ClassLibrary
{
   public class AccesoDatos
    {
        //primero configurar el objet tipo SqlConnection, para esto hay que innstancialro.
        //importante acceder al namespace Properties.Settings.Default.NombreQueLeAsigno
        private SqlConnection conexion;

        private SqlCommand SqlCommand; // se intancia cada vez que se necesite utilizar por eso no va en el contructor
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
        }
        //TRAER ELEMENTOS DE LA BASE DE DATOS
        public List<Persona> TraerTodos()
        {
            List<Persona> personas = new List<Persona>();

            this.SqlCommand = new SqlCommand();
            this.SqlCommand.Connection = this.conexion;
            this.SqlCommand.CommandType = CommandType.Text;
            this.SqlCommand.CommandText = "SELECT * from Padron.dbo.Personas ";
            this.conexion.Open();
            SqlDataReader sqlDataReader = this.SqlCommand.ExecuteReader(); //this.SqlCommand.ExecuteReader(); ejecuta  la consulta
            // sqlDataReader[] o sqlDataReader[nombreColumna]
            while (sqlDataReader.Read())
            {
                Persona p = new Persona((int)sqlDataReader[0], sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), (int)sqlDataReader[3]);
                personas.Add(p);
            }
            this.conexion.Close();
            return personas;
        }
        public bool AgregarPersona(Persona persona)
        {
            bool flag = false;
            this.SqlCommand = new SqlCommand();
            try
            {
                this.SqlCommand.Connection = this.conexion;
                this.SqlCommand.CommandType = CommandType.Text;
                this.SqlCommand.CommandText = " insert into Padron.dbo.Personas (nombre,apellido,edad) values('" + persona.nombre + "','" + persona.apellido + "','" + persona.edad.ToString() + "')";
                this.conexion.Open();
                int valor =  this.SqlCommand.ExecuteNonQuery();
               
                if (valor>0)
                    this.conexion.Close();
                flag = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return flag;

        }
        public bool ModificarPersona(Persona persona)
        {
            bool flag = false;
            
            this.SqlCommand = new SqlCommand();
            try
            {
                this.SqlCommand.Connection = this.conexion;
                this.SqlCommand.CommandType = CommandType.Text;
                this.SqlCommand.CommandText = " update Padron.dbo.Personas set nombre ='"+persona.nombre+"',apellido = '"+persona.apellido+"',"+"edad =" +persona.edad.ToString() + " where id = " +persona.id.ToString();
                this.conexion.Open();
                int valor = this.SqlCommand.ExecuteNonQuery();
                if (valor > 0)
                this.conexion.Close();
                flag = true;
            }
            catch (Exception)
            {

                throw;
            }
            return flag;
        }
        public bool EliminarPersona(int id)
        {
            bool flag = false;
            this.SqlCommand = new SqlCommand();
            try
            {
                this.SqlCommand.Connection = this.conexion;
                this.SqlCommand.CommandType = CommandType.Text;
                this.SqlCommand.CommandText = " delete from  Padron.dbo.Personas  where id ="+id.ToString(); 
                this.conexion.Open();
                int valor = this.SqlCommand.ExecuteNonQuery();

                if (valor > 0)
                {
                    this.conexion.Close();
                    flag = true;
                }
                  
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return flag;
        }
        //Datatable es independiente del proveedor de datos no depende de sql
        public DataTable TablaPersona()
        {
            DataTable dataTable = new DataTable("Personas");
            this.SqlCommand = new SqlCommand();
            this.SqlCommand.Connection = this.conexion;
            this.SqlCommand.CommandType = CommandType.Text;
            this.SqlCommand.CommandText = "SELECT * from Padron.dbo.Personas ";
            this.conexion.Open();
            SqlDataReader sqlDataReader = this.SqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            this.conexion.Close();

            return dataTable;
        }
    }

}
