using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    public class Vehical
    {
        private String Brand;
        private String Model;
        private double price ;
        protected int Wheels;
        public double insurance ;

        public Vehical()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Price = 0;
            Wheels = 0;
            insurance = 0;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void input()
        {
            Console.WriteLine("Enter the brand name");
            Brand = Console.ReadLine()?? " ";
            Console.WriteLine("Enter the Model name");
            Model = Console.ReadLine() ?? " ";
            Console.WriteLine("Enter the Price ");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine("Brand Name:" + Brand);
            Console.WriteLine("Model Name:" + Model);
            Console.WriteLine("Price :" + Price);

        }
        public virtual void Cal_Insurance()
        {
            insurance = (5 /100)*(Price);
        }

    }
    public class Car:Vehical

    {
        String FuelType;
        public Car()
        {
            FuelType= "Unknown";
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Enter the Fueltype(Petrol/Diesel)");
            FuelType = Console.ReadLine() ?? " ";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("FuelType is : "+FuelType);
        }

        public override void Cal_Insurance()
        {
            base.Cal_Insurance();
            if(FuelType=="Petrol" || FuelType=="petrol")
            {
                insurance =(6 / 100) * (Price);
            }
            else
            {
                insurance = (7 / 100) * (Price);
            }
        }


            
    }
    class Truck : Vehical
    {
        int LoadCapacity;
        public override void input()
        {
            base.input();
            Console.WriteLine("Enter the LoadCapacity ");
            LoadCapacity = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Load Capacity : " + LoadCapacity);
        }
        public override void Cal_Insurance()
        {

            insurance = ((8 / 100) * (Price))+(LoadCapacity*500);
        }
    }
    class VehicalManager : Vehical
    {
        Vehical[] v1 =new Vehical[2]; 
        String Vehical_type;
       VehicalManager()
        {
            Vehical_type = "Unknown";
        }

        public void AcceptAll()
        {

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Choose Vehical type (Car/Truck)");
                Vehical_type = Console.ReadLine()!;
                if (Vehical_type == "car" || Vehical_type == "CAR" || Vehical_type == "Car")
                {
                    v1[i]=new Car();
                }
                else
                {
                    v1[i]=new Truck();
                }
                v1[i].input();
            }

        }
        public void ShowAll()
        {
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                v1[i].Display();
            }
            Console.WriteLine();
        }
        public void ShowInsuranceForAll()
        {

            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                v1[i].Cal_Insurance();
                Console.WriteLine("Insurance:" + v1[i].insurance);
            }
            Console.WriteLine();
        }
        public void FindMostExpensive()
        {
            double max_price = v1[0].Price;
            int index = 0;
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                if (max_price < v1[i].Price)
                {
                    max_price = v1[i].Price;
                    index = i;

                }
                else
                {
                    index = i;
                }
                Console.WriteLine("Most Expensive Vehical ");
                v1[index].Display();
            }
            Console.WriteLine();
            
            
        }
    }
    //hiii


}
