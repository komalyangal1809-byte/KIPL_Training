using DELEGATES_CSHARP;
using System;

class Program
{
    public static void Main(String[] args)
    {
        //Delegate_demo_1 d = new Delegate_demo_1();
        //myAction action;
        //action = d.SayHello;
        //action();
        //action = d.SayBye;
        //action();


        //Delegate_demo_2 d1= new Delegate_demo_2();
        //Action<String> notify=null;
        //notify+=d1.SendMail;
        //notify-= d1.SMS;
        //notify+= d1.Log;

        //notify("User Registered");


        //Delegate_demo_2 d2=new Delegate_demo_2();
        //Delegets_demo_3 d3=new Delegets_demo_3();
        //callBack notify=null;
        //notify = d2.SendMail;
        //notify += d2.SMS;
        //notify += d2.Log;
        //d3.Register(notify);


        Discount_service service= new Discount_service();

        DiscountRule rule;

        rule = service.FestivalDiscount;
        rule += service.PremiumDiscount;
        rule += service.CouponDiscount;

        Console.WriteLine("Final price of the product:= "+ rule(1000));




    }
  

}