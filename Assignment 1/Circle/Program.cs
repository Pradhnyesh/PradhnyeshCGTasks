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
            double r;
            Console.WriteLine("Enter radius of a circle");
            r=Convert.ToDouble(Console.ReadLine());
            AreaCircumference(r);
        }

        public static void AreaCircumference(double radius)
        {
            double area = 3.14 * radius * radius;
            double circumference = 2 * 3.14 * radius;
            Console.WriteLine("Area of Circle is " + area + " Circumference of Circle is " + circumference);
        }

        
    }
}

