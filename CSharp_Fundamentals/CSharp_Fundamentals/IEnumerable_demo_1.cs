using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    class Product
    {
        private int id { get; set; }
        public String product_name { get; set; }
        public int price { get; set; }

        public Product()
        {
            this.id =0;
            this.product_name = "Unknown";
            this.price = 0;

        }
        public void input()
        {
            Console.WriteLine("Enter the Product id ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product name ");
            product_name = Console.ReadLine()!;
            Console.WriteLine("Enter the Product price ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public int getId()
        {
            return id;
        }
                  
    }
    internal class IEnumerable_demo_1:Product
    {
        public void Display_product()
        {
            Console.WriteLine("Enter the how many products ");
            int n=Convert.ToInt32(Console.ReadLine());


            List<Product> l1 = new List<Product>();
            for(int i=0;i<n;i++)
            {
                Product p=new Product();
                p.input();
                l1.Add(p);
            }

            Console.WriteLine("\nProducts: ");
            IEnumerable<Product> product =l1 ;
            foreach (Product item in product)
            {

                Console.WriteLine("Product Id: " + item.getId() + " Product name:" + item.product_name + " Price:" + item.price);
            }

        }
    }
}
