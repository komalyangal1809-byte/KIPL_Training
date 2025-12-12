using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    internal class Assignment_NO_4
    {
        public String Name;
        double Price;
        public int Quantity;
        double bill = 0;

        public Assignment_NO_4(String Name, double Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    
        //Method Overloading
        public String Add(String Name ,String Name1)
        {
            return Name + Name1;
        }
        public double Add(Double Price,int Quantity) 
        {
            bill= Price*Quantity;
            return bill;
        }
        public void Display_Items()
        {
            Console.WriteLine("Product Name : " + Name);
            Console.WriteLine("Quantity : "+Quantity);
            Console.WriteLine("total Price : " + bill);
        }

    }
}
