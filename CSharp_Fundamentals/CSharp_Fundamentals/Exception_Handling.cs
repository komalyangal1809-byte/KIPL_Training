using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    class Student
    {  
        double avg = 0;
        public String Name { get; set; }
        public int[] marks = new int[5];

       public  Student()
        {
            Name = "";
        }

        public void InputMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                try
                {
                    Console.WriteLine("Enter the marks ");

                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0 || num > 100)
                        throw new Exception_Handling("Marks between 0 to 100");

                    marks[i] = num;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter the number only ");
                    i--;
                }
                catch (Exception_Handling ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
        }
        public void Cal_Average()
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            avg = total / 5;
        }
        public void Display()
        {
            Console.WriteLine("The Average of marks is " + avg);
        }
}
internal class Exception_Handling:Exception
    {
        public Exception_Handling(String message) : base(message)
        { 
        }
    }
}
