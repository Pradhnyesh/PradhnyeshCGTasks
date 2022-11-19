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
            int n;
            Console.WriteLine("Enter the number of digits you want to find sum of: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumOfArray(array);
        }

        public static void SumOfArray(int[] array)
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum = Sum + array[i];
            }
            Console.WriteLine("Sum of all the integers is: " + Sum );
        }

        
    }
}

