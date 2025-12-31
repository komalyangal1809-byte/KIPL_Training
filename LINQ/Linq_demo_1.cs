using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    internal class Linq_demo_1
    {
        public void method()
        {
            List<int> list = new List<int>() { 11,2,4,5,6,12,13,14,15,1,3,7,8,9,10};
            List<String> list1 = new List<String>() {"komal","sneha","Mohini","Neha"};

            Console.WriteLine("Number which greter than 10 ");
            var greterNum=from i in list 
                          where i>10
                          select i;
            foreach(var i in greterNum)
                Console.WriteLine(i);

            Console.WriteLine("Names in uppercase ");
            var nameUpperCase=from i in list1
                              select i.ToUpper();

            foreach (var name in nameUpperCase)
                Console.WriteLine(name);

            Console.WriteLine("Numbers in ascending orders");
            var sortNum=from i in list
                        orderby i
                        select i;

            foreach (var i in sortNum)
                Console.WriteLine(i);

            var evenNum = list.First(i=>i%2==0);

            Console.WriteLine("First Even number is "+evenNum);

            var greter_num = list.Any(i => i > 20);

            Console.WriteLine("Number greter than 20 is present? "+greter_num);

        }
    }
}
