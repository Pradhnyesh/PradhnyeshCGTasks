using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{

    public class Employee
    {
        private int EmpId;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public int GetEmpId()
        {
            return EmpId;
        }
        public void SetEmpId(int id)
        {
            this.EmpId = id;
        }

        public string GetEmpName()
        {
            return EmpName;
        }
        public void SetEmpName(string name)
        {
            this.EmpName = name;
        }

        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            this.Salary = salary;
        }

        public void CalculateSalary(double salary)
        {
            if (salary < 5000)
            {
                HRA = 0.1 * salary;
                TA = 0.05 * salary;
                DA = 0.15 * salary;
            }
            else if (Salary >= 5000 && Salary < 10000)
            {
                HRA = 0.15 * salary;
                TA = 0.1 * salary;
                DA = 0.2 * salary;
            }

            else if (salary >= 10000 && salary < 15000)
            {
                HRA = 0.2 * salary;
                TA = 0.15 * salary;
                DA = 0.25 * salary;
            }
            else if (salary >= 15000 && salary < 20000)
            {
                HRA = 0.25 * salary;
                TA = 0.2 * salary;
                DA = 0.3 * salary;
            }

            else if (salary >= 20000)
            {
                HRA = 0.3 * salary;
                TA = 0.25 * salary;
                DA = 0.35 * salary;
            }

            GrossSalary = salary + HRA + TA + DA;
            PF = GrossSalary * 0.1;
            TDS = GrossSalary * 0.18;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("\n GrossSalary : " + GrossSalary + "\n NetSalary : " + NetSalary);

        }

    }
}
