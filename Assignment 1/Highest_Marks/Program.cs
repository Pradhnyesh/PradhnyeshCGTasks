using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Marks
{
    class program
    {
        public static void Main(string[] args)
        {
            double[] marks = new double[5];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter Average Marks of " + (i+1) + " Studet");
                marks[i] = Convert.ToDouble(Console.ReadLine());
            }
            double highest = GetHighest(marks);
            Console.WriteLine("Highest marks obtain are: " + highest);
        }


        public static double GetHighest(double[] avgmarks)
        {
            double highest = avgmarks[0];
            for(int i = 0; i < avgmarks.Length; i++)
            {
                if(avgmarks[i] > highest)
                    highest = avgmarks[i];
            }
            return highest;
        }
    }   
}
