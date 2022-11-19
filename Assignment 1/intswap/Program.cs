using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_number
{
    class program
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b= Convert.ToInt32(Console.ReadLine());
            Swap(a, b);
        }

        public static void Swap(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping numbers: \n" );
            Console.WriteLine("First number is: " + a + " Second number is: " + b);
        }

     
    }
}

