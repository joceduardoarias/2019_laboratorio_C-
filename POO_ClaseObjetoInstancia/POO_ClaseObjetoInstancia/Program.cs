using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClaseObjetoInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do { } while ();

            menu();
        }
        /*NOTA: El main es la parte central del programa tal cual sucede con C
         los metodos se desarollan por fuera del main*/
        //Creando metodo menu
        public static int menu()
        {
            int retorno = 1;
            //Limpiar pantalla
            Console.Clear();
            //Imprimir menu
            
                Console.WriteLine("1. Asignar Nombre de Titular de la cuenta");
                Console.WriteLine("2. Asignar numero de cuenta");
                Console.WriteLine("3. Imprimir datos de la cuenta");
                Console.WriteLine("4. Realizar deposito");
                Console.WriteLine("5. Realizar retiro");
                Console.WriteLine("6. Consultar Saldo");
                Console.WriteLine("7. Aplicar Interes");
                Console.WriteLine("8. Salir");
                retorno = Console.Read();
            
            
            return retorno;
        }
    }

    class CCuenta
    {
        //Atributos
        private string nombre;
        private string cuenta;
        private double saldo;
        private double porcentajeDeInteres;
        //Contructor
        public CCuenta()
        {
        }
        //Metodos
        public void asignarNombreCliente(string cadena)
        {
            nombre = cadena;
        }
        public string obtenerNombreCliente()
        {
            return nombre;
        }
        public void AsignarNumeroCta(string numero)
        {
            cuenta = numero;
        }
        public void deposito(double valor)
        {
            saldo = saldo + valor;
        }
        public void retiro(double valor)
        {
            saldo = saldo - valor;
        }
        public void asignarInetereses(double valor)
        {
            porcentajeDeInteres = valor;
        }
        public double consultarIntereses()
        {
            return porcentajeDeInteres;
        }
        public void aplicarInteres()
        {
            saldo = saldo + (saldo * porcentajeDeInteres);
        }
        public double obtenerSaldo()
        {
            return saldo;
        }
    }
}
