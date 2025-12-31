using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Assignment_NO_5
    {
        private String name;
        private int age;
        private char grade;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age is Invalid ");
            }
        }
        public char Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public void input()
        {
            Console.WriteLine("Enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Age:");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Grade");
            Grade=char.Parse(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
