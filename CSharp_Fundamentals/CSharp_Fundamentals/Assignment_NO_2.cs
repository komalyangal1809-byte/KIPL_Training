using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Assignment_NO_2
    {
        String First_name, Last_name;
        int Age;
        double Height;
        bool student;

        public void input()
        {
            Console.WriteLine("Enter the First Name");
            First_name=Console.ReadLine();
            Console.WriteLine("Enter the Last Name ");
            Last_name = Console.ReadLine();
            Console.WriteLine("Enter the Age ");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the Student");
            Height=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you Student?");
            String Ans=Console.ReadLine();
            if(Ans=="yes" || Ans=="Y" || Ans=="y" || Ans=="YES")
            {
                student = true;
            }else
            {
                student = false;
            }
               
        }
        public void Display()
        {
            Console.WriteLine("Full Name:"+First_name+" "+Last_name);
            Console.WriteLine("Age      :"+Age);
            Console.WriteLine("Height   :"+Height+" cm");
            Console.WriteLine("Student  :"+student);
            Console.WriteLine("Date     :"+DateOnly.FromDateTime(DateTime.Now));
        }
     
    }
}
