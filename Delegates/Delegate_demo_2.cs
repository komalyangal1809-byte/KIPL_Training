using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void Action(String msg);
namespace DELEGATES_CSHARP
{
    internal class Delegate_demo_2
    {
        public void SendMail(String msg)
        {
            Console.WriteLine("Email: "+msg);
        }
        public void SMS(String msg)
        {
            Console.WriteLine("SMS: "+msg);
        }
        public void Log(String msg)
        {
            Console.WriteLine("Log: "+msg);
        }

    }
}
