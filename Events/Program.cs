namespace Events
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            for (int i = 0; i <= 100; i++)
            {
                emp.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee {i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deduction = Random.Shared.Next(100, 500),
                    Bonus = Random.Shared.Next(100, 500)
                });
            }
            SalaryCalculator salary = new SalaryCalculator();
            salary.CalculateSalary(emp, (e) => e.BasicSalary <= 2000);
        }

        
    }
}
