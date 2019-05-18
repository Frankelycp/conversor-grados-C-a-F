using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static double numero ()
        {
            double grados;
            Console.WriteLine("Ingrese grados Centigrados");
            grados = Convert.ToDouble(Console.ReadLine());
            return grados;

        }
        static void Main(string[] args)
        {
            double grados;
            double far = 0;
   
            grados = numero();
            if (grados > 0)
            {
                Console.WriteLine("Los grados Centigrados ingresados son " + grados + "°" + "\n");
                double fa = ((9.0 / 5.0) * grados + 32);
                Console.WriteLine("Los Grados Ingresados anteriormente convertidos a Fahrenheit son " + fa + "°" + "\n");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Ingrese un numero mayor a 0 ");
            Console.ReadKey();
        }
 
    }
}
