using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    internal class Linq_demo_2
    {
        public String Name { get; set; }
        public int Marks { get; set; }



        public void Method()
        {
            List<Linq_demo_2> students = new List<Linq_demo_2>()
            {
                new Linq_demo_2 {Name="Alice",Marks=90},
                new Linq_demo_2 {Name="Bob",Marks=85},
                new Linq_demo_2 {Name="Charli",Marks=60}
            };
            Console.WriteLine("Student who scored more than 70");
            var greterMarks = from i in students
                              where i.Marks > 70
                              select i.Name;

            foreach (var i in greterMarks)
                Console.WriteLine(i);

            Console.WriteLine("\nStudent Names: ");
            //var names =from i in students
            //           select i.Name;
            var names = students.Select(i => i.Name).ToList();
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine("\n Sorting by students marks:");
            var marks = from name in students
                        orderby name.Marks descending  
                        select new
                        {
                            name.Name,
                            name.Marks
                        };       
            foreach (var name in marks)
                Console.WriteLine(name);

            //var count = students.Count(i=>i.Marks>70);
            var count=(from i in students
                      where i.Marks>70
                      select i).Count();
            
            Console.WriteLine("\nTotal number of sstudents who scored more than 70% is "+count);

            var pass = students.All(i => i.Marks > 50);
            Console.WriteLine("\nAll Students are pass or not? "+pass);

            Console.WriteLine("Name starting with 'A'");
            var name_marks = from i in students
                             where (i.Marks > 70 && i.Name.StartsWith('A'))
                             select i.Name;

            foreach (var name in name_marks)
                Console.WriteLine(name);
        }
    }
}