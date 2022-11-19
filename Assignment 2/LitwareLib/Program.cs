using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib

{
    class Program
    {

        static void Main(string[] args)
        {
            int id;
            string name;
            double salary;
            Employee emp = new Employee();
            Console.WriteLine("\nEnter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Employee Name : ");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter Employee Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());

            emp.SetEmpId(id);
            emp.SetEmpName(name);
            emp.SetSalary(salary);

            emp.CalculateSalary(salary);
        }
    }
}

