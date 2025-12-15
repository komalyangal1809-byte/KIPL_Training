using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void myAction();
namespace DELEGATES_CSHARP
{
    internal class Delegate_demo_1
    {
         public void SayHello()
         {
            Console.WriteLine("Hello");
         }
        public  void SayBye()
         {
            Console.WriteLine("Bye");
         }
        
    }
}
