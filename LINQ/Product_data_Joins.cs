using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    internal class Product_data_Joins
    {
        public String ProductName { get; set; }
        public String ProductId { get; set; }
        public int CategoryId { get; set; }

        public void input()
        {
            List<Product_data_Joins> list = new List<Product_data_Joins>()
            {
                 new Product_data_Joins { ProductId = "p01", ProductName = "Laptop", CategoryId = 1 },
                 new Product_data_Joins { ProductId = "p02", ProductName = "Phone", CategoryId = 2 },
                 new Product_data_Joins { ProductId = "p03", ProductName = "Headphone", CategoryId = 3 },
                 new Product_data_Joins { ProductId = "p04", ProductName = "shirt", CategoryId = 4},
            };
           

        }
       

             
    }
    class Categories
    {
        public String CategoryName { get; set; }
        public int CategoryId { get; set; }

        public void input()
        {
            List<Categories> list = new List<Categories>() {
                new Categories {CategoryId=1,CategoryName="Electronic"},
                new Categories {CategoryId=2,CategoryName="Electronic"},
                new Categories{CategoryId=3,CategoryName="Electronic"},
                new Categories{CategoryId=4,CategoryName="Clothing" }
            };
        }
    }
}
