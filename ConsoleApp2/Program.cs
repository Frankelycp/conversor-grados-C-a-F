using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorGradosCaF
{
    class Program
    {



        public static double numero()
        {
            double grados;
            Console.WriteLine("Ingrese grados Centigrados");
            grados = Convert.ToDouble(Console.ReadLine());
            return grados;

        }
        static void Main(string[] args)
        {
            double grados;

            do

            {
                grados = numero();
                Console.WriteLine("Los grados Centigrados ingresados son " + grados + "°" + "\n");
                double fa = ((9.0 / 5.0) * grados + 32);
                Console.WriteLine("Los Grados Ingresados anteriormente convertidos a Fahrenheit son " + fa + "°" + "\n");
            }
            while (grados  >= - 100 && grados <200);

            Console.ReadKey();
        }

    }
}


