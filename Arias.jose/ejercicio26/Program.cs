using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array;
            array = new int[20];
            int[] aux;
            aux = new int[20];
            Random num = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num.Next(-100, 100);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************");
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************");
            for (int i = 0; i < array.Length; i++)
            {   
                if(array[i] < 0)
                {
                    aux[i] = array[i];   
                }
                
            }
            foreach (var item in aux)
            {   if(item != 0)
                Console.WriteLine(item);
            }

        }
    }
}
