using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Linq_Demo1
    {
        public void method1()
        {
            int[] arr = { 30, 40, 50, 67, 89, 90, 98, 32 };
            var a = from i in arr where i > 30 orderby i descending select i;
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
