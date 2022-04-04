using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{


        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        class Program
        {




            public static void Main()
            {
                List<string> Things = new List<string>() { "a", "b", "c", "d" };
                Console.WriteLine("An Employee in position 0 :" + Things[0]);
                Console.WriteLine("An Employee in position 3 :" + Things[3]);
                List<int> things = new List<int>() { 1, 3, 7, 9 };
                Console.WriteLine("An Employee in position 0 :" + things[0]);
                Console.WriteLine("An Employee in position 3 :" + things[3]);
                

                List<Employee> employees = new List<Employee>()
                {
                    new Employee {Id= 1, FirstName="Jessica", LastName="Ring"},
                    new Employee {Id= 5, FirstName="Stefan", LastName="King"},
                    new Employee {Id= 74, FirstName="Jeremy", LastName="Iron"},
                    new Employee {Id= 74, FirstName="Jayden", LastName="Storm"},
                };
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine("Id:{0}, First Name :{1} Last Name:{2}",employees[i].Id,employees[i].FirstName,employees[i].LastName);
                }
                Console.ReadLine();



            }
        }

    }
}
