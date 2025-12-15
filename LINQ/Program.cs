using LINQ_CSharp;

class Program
{
    public static void Main(String [] args)
    {


        //List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,10,11 };

        //var num = from i in list
        //          where (i % 2) == 0
        //          orderby  (i)
        //          select i;

        //foreach(var i in num )
        //    Console.WriteLine(i);

        //Linq_demo_1 l=new Linq_demo_1();
        //l.method();

        //Linq_demo_2 l2=new Linq_demo_2();
        //l2.Method();

        Employee_data employee = new Employee_data();
        employee.Method();
    }
}