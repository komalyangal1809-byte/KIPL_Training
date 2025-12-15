using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void callBack(String msg);
namespace DELEGATES_CSHARP
{
    internal class Delegets_demo_3
    {
        public void Register(callBack notify)
        {
            Console.WriteLine("User Registered ");

            notify("welcome user!");
        }

    }
    
}
