using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface Employee
    {
        public void DoWork();
    }
    public class Engineer : Employee
    {
        public void DoWork()
        {
            Console.WriteLine("Do the work");
        }
    }
    public class CompanyEntance<T> where T : class,Employee
    {
        public void LogToCompany(T emp)
        {
            Console.WriteLine("You are in");
        }
    }
}
