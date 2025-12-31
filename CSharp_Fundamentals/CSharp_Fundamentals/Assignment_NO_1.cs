using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Assignment_NO_1
    {
        public void print()
        {
            Console.WriteLine("Hello, Welcome to C# ");
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("Today's Date " + today);

            Console.WriteLine();

            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            DayOfWeek day = DateTime.Now.DayOfWeek;
            Console.WriteLine("Name: Komal");
            Console.WriteLine("Date:" + today.ToString("yyyy-MM-dd"));
            Console.WriteLine("Time:" + time);
            Console.WriteLine("Day: " + day);
            Console.WriteLine("Message: I started the C# Fundamentals");
        }
    }
}
