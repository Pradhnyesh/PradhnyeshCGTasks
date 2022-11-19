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
            double a, b, result;
            int c;
            do
            {
                Console.WriteLine("Select: 1.For Addition, 2.For Subtraction, 3.For Multiplication, 4.For Division");
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 1 || c > 4)
                    Console.WriteLine("Please Enter Number Between 1 & 4");
            } while (c < 1 || c > 4);
           
            Console.WriteLine("Enter First Number");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0 && c == 4)
                Console.WriteLine("Division by zero not possible");
            else if(c==1)
            {
                result = Addition(a, b);
                Console.WriteLine("Addition is equal to:"+result);
            }

            else if (c == 2)
            {
                result = Subtraction(a, b);
                Console.WriteLine("Subtraction is equal to:" + result);
            }

            else if (c == 3)
            {
                result = Multiplication(a, b);
                Console.WriteLine("Multiplication is equal to:" + result);
            }

            else if (c == 4)
            {
                result = Division(a, b);
                Console.WriteLine("Division is equal to:" + result);
            }

        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return (a * b);
        }

        public static double Division(double a, double b)
        {
            return (a / b);
        }
    }       
}
