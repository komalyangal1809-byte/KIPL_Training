using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Assignment_NO_3
    {
        public String Name;
        private int RollNo;
        int[] marks=new int[3];
        double Per;
        String Grade;
           
        public void User_Input()
        {
            Console.WriteLine("Enter the Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the RollNo ");
            RollNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of the Students ");
            for(int i = 0;i<3;i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Cal_Percentage()
        {
            double total=0;
            for (int i = 0; i < 3; i++)
            {
                total = total+marks[i];
            }
            Per=total/3;
        }
        public void Cal_Grade()
        {
            if (Per >= 90)
                Grade = "A+";
            else if (Per >= 80 && Per < 90)
                Grade = "A";
            else if(Per>=70 && Per<80)
                Grade = "B";
            else if(Per>=60 && Per<70)
                Grade = "C";
            else
                Grade = "Fail";

        }
        public void Display_Details()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Roll No :"+RollNo);
            Console.Write("Marks: ");

            for (int i = 0; i < 3; i++) {
                Console.Write(marks[i]+",");
            }
            Console.WriteLine();
            Console.WriteLine("Percentage: "+Per);
            Console.WriteLine("Grade:"+Grade);
        }
    }
}
