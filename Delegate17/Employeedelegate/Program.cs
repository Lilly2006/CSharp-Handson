using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "Ravi", salary = 20000, Experiance = 3 });
            empl.Add(new Employee() { ID = 102, Name = "John", salary = 30000, Experiance = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Mary", salary = 50000, Experiance = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Mike", salary = 10000, Experiance = 2 });
            Employee.PromoteEmp(empl);
            Console.ReadKey();
        }
       
        public static bool promote(Employee emp)
        {
            if (emp.Experiance >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
        
    }
}
