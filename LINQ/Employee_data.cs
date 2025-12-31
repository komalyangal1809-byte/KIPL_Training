using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    internal class Employee_data
    {
        public String Name { get; set; }
        public int Marks { get; set; }
        public String Department { get; set; }
        public int Salary { get; set; }

        public Employee_data()
        {
            Name = "Unknown";
            Department = "Unknown";
        }
        public void Method()
        {
            List<Employee_data> Employees = new List<Employee_data>() {
            new Employee_data {Name="komal",Marks=69,Department="CSE",Salary=10000},
            new Employee_data {Name="Neha",Marks=59,Department="IT",Salary = 20000},
            new Employee_data {Name="Mohini",Marks=89,Department="CSE",Salary=10000},
            new Employee_data {Name="Sneha",Marks=99,Department="EN&TC",Salary = 30000},
            new Employee_data {Name="Sakshi",Marks=94,Department="IT",Salary = 25000},
            new Employee_data {Name="Shruti",Marks=90,Department="CSE",Salary = 10000},
            };

            var group = from i in Employees
                        where i.Department == "IT"
                        group i by i.Department into depart
                        select new
                        {
                            Department = depart.Key,
                            Employees = depart
                        };

            foreach (var g in group) {
                foreach (var e in g.Employees)
                {

                    Console.WriteLine(e.Name + ": " + e.Department);
                }
            }

            Console.WriteLine("\nCount of each department ");
            var count = from i in Employees
                        group i by i.Department into depart
                        select new
                        {
                            Department = depart.Key,
                            countdepart = depart.Count()
                        };

            foreach (var g in count)
            {
                Console.WriteLine(g.Department+": "+g.countdepart);
            }

            Console.WriteLine("\nAverage Salary of each department:");
            var avg_sal = from i in Employees
                          group i by i.Department into depart
                          select new
                          {
                              Department = depart.Key,
                              avg = depart.Average(i => i.Salary)
                          };

            foreach (var g in avg_sal)
            {
                Console.WriteLine(g.Department + ": " + g.avg);
            }

            Console.WriteLine("\nNames of Employees of each department:");
            var names = from i in Employees
                        group i by i.Department into depart
                        select new
                        {
                            Department = depart.Key,
                            Employee=depart
                        };

            foreach (var item in names)
            {               
                    Console.Write(item.Department+":");
                foreach(var g in item.Employee)
                    Console.Write(g.Name+",");

                Console.WriteLine();
            }
            Console.WriteLine();
        }
     }
       
    
}
