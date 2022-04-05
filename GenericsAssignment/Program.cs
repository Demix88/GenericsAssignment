using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        public class Employee<T>
        {

            public List<T> Things { get; set; }



        }
        public static void Main(string[] args)
        {

            Employee<string> emp1 = new Employee<string>();
            Employee<int> emp2 = new Employee<int>();
            emp1.Things = new List<string>();
            emp1.Things.Add("Chris");
            emp1.Things.Add("Bob");
            emp1.Things.Add("Richard");
            emp1.Things.Add("Natalia");
            emp1.Things.Add("Rebekah");

            emp2.Things = new List<int>();
            emp2.Things.Add(007);
            emp2.Things.Add(003);
            emp2.Things.Add(695);
            emp2.Things.Add(027);
            emp2.Things.Add(197);

            for (int i = 0; i < emp1.Things.Count; i++)
            {
                Console.WriteLine("Employee Name :{0} ", emp1.Things[i]);

            }
            for (int i = 0; i < emp2.Things.Count; i++)
            {
                Console.WriteLine(" Employee ID :{0} ", emp2.Things[i]);
            }
            Console.ReadLine();


        }
    }
}

