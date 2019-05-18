using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

    
        static void Main(string[] args)
        {
            int num = 0;
            int num2 = num;
            int num3 = 0;
            
            for (num=0 ; num<= 40; num++)
            {

                Console.WriteLine("la serie es " + num + "+" + num3 + " = " + num2 );
                num2 = num2 + num;
                num3 = num;

            }
            Console.ReadKey();
        }

    }
}

