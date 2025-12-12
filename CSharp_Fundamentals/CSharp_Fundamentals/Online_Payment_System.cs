using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    public interface Payment_methods
    {
         void MakePayment();
         void RefundPayment();
         void CheckBalance();
    }

    internal class Online_Payment_System : Payment_methods
    {
        String pay_method;
        double amount;
        double balance;
        String refund;
        String Bal_check;

      public Online_Payment_System()
        {
            pay_method = "Unknown";
            amount = 0;
            balance = 4000;
            refund = " ";
            Bal_check = " ";
        }
        public void MakePayment()
        {
            Console.WriteLine("Choose Payment Method(Card)");
            pay_method = Console.ReadLine()!;
            if(pay_method.Equals("card",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the amount to pay ");
                amount = Convert.ToDouble(Console.ReadLine());
                if (balance - amount < 2000)
                    Console.WriteLine("Not efficient balance ");
                else {
                    balance = balance - amount;
                    Console.WriteLine("Payment of Rs." + amount + " through CARD is successful!");
                }
                    
            }
        }
        public void RefundPayment()
        {
            Console.WriteLine("Do you want to refund?");
            refund = Console.ReadLine()!;
            if (refund.Equals("yes", StringComparison.OrdinalIgnoreCase)) 
            {
                balance = balance + amount;
                Console.WriteLine("Refund of Rs." + amount + " successfull");
            }
            else
            {
                Console.WriteLine("No refund request.");
            }

        }
        public void CheckBalance()
        {
            Console.WriteLine("Do you want to check Balance?");
            Bal_check = Console.ReadLine()!;
            if (Bal_check.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Available Balance is "+balance);
            }
            else
            {
                Console.WriteLine("No request for balance checking ");
            }
        }

    }
}
