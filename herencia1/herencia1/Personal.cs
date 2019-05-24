using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    class Personal
    {   
        //Atributos
        private int _id;
        private string _Nombre;
        private string _Apellido;
        public string comment = "Hola Hijo";

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        //Constructor
        public Personal(int pId,string pNombre, string pApellido)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
        }  
        //Agregando un metodo
        public int Suma(int a,int b)
        {
            return a + b;
        }
    }
    // Herencia
    // Clase profesor hereda de la clase Personal
    class profesor:Personal
    {   
        // Agregando un atributo
        public string direction;
        public string direc
        {
            get { return direction; }
            set { direction = value; }
        }
        //Creando constructor para que tome los parametros de la clase padre Personal y tome un nuevo paramtro
        //que solo pertenece a la clase hija Profesor.
        public profesor(int pId,string pNombre,string pApellido,string pDirection):base(pId,pNombre,pApellido)
        {
            direction = pDirection;
        }
        public int Suma(int a, int b, int c)
        {
            return a + b + c;
        }
        /*
            NOTA: dentro de esta clase se puede agregar mas metodos, atributos y operadores.
         */
    }
    
}
