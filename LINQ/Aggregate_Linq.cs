using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    internal class Aggregate_Linq
    {
        List<int> list=new List<int>() { 1,2,3,4};
        List<string> names = new() { "Komal", "Ankita", "Sakshi" };
        public void input()
        {
            var res = list.Aggregate(1,(acc,n)=>acc*n);
            Console.WriteLine("Product of numbers is "+res);

            var res1 = list.Aggregate(10,(acc,n)=>acc+10);
            Console.WriteLine("Adding 10 to each number "+res1);

            var res2 = names.Aggregate((a,b)=>a+"|"+b);
            Console.WriteLine("Names are: "+res2);

            List<int> empty=new List<int>() { };
            Console.WriteLine("empty" + empty.Aggregate( 1,(acc, n) => acc * n));
        }

    }
}
