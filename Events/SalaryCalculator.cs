using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    
    internal class SalaryCalculator
    {
        public delegate bool Show(Employee employee);
        public event ?? EmployeeSalaryCalculated;
        public void CalculateSalary(List<Employee> employee, Show predicate)
        {
            foreach (Employee emp in employee)
            {
                if (predicate(emp))
                {
                    var salary = emp.BasicSalary + emp.Bonus + emp.Deduction;
                    Console.WriteLine($"Salary for employee {emp.Name} with basic salary {emp.BasicSalary} = {salary}");
                }

            }
        }
    }
}
