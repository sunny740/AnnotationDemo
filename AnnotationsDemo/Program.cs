using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.Name = "Su";
            employee.Id = 10123;
            employee.Email = "Sej007@.com";
            employee.Age = 23;
            employee.MobileNumber = 9012345678;
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.MobileNumber);
        }
    }
}
