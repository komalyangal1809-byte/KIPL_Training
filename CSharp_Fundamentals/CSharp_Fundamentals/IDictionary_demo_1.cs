using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class IDictionary_demo_1
    {
        public void dictMethod()
        {
            IDictionary<int, String> id = new Dictionary<int, String>();
            id.Add(416115, "Ichlakarnji");
            id.Add(411026, "Pune");

            

            Console.WriteLine(id);

            if (id.ContainsKey(411234))
                Console.WriteLine("Sangli is present");
            else Console.WriteLine("sangli is not present");


            id.Add(400002, "Mumbai");

            id[400002] = "Kolhapur";

            


            id.Remove(40002);
            foreach(var item in id)
            {
                Console.WriteLine(" key: "+item.Key+"  Value: "+item.Value);
            }
            

        }

    }
}
