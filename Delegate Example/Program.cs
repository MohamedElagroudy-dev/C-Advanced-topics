namespace Delegate_Example
{
    internal class Program
    {
        delegate bool Show(Employee employee);
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal BasicSalary { get; set; }
            public int Bonus { get; set; }
            public int Deduction { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            for(int i = 0; i <= 100; i++) 
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
            CalculateSalary(emp,(e) => e.BasicSalary <= 2000);
        }

        static void CalculateSalary(List<Employee> employee,Show predicate )
        {
            foreach(Employee emp in employee)
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
