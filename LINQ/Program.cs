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

        //Employee_data employee = new Employee_data();
        //employee.Method();

        //List<Product_data_Joins> products = new List<Product_data_Joins>()
        //    {
        //         new Product_data_Joins { ProductId = "p01", ProductName = "Laptop", CategoryId = 1 },
        //         new Product_data_Joins { ProductId = "p02", ProductName = "Phone", CategoryId = 2 },
        //         new Product_data_Joins { ProductId = "p03", ProductName = "Headphone", CategoryId = 3 },
        //         new Product_data_Joins { ProductId = "p04", ProductName = "shirt", CategoryId = 4},
        //    };

        //List<Category> categories = new List<Category>()
        //{
        //    new Category { CategoryId = 1, CategoryName = "Electronic" },
        //    //new Category { CategoryId = 2, CategoryName = "Electronic" },
        //    new Category { CategoryId = 3, CategoryName = "Electronic" },
        //    new Category { CategoryId = 4, CategoryName = "Clothing" }
        //};

        //var result = from i in products
        //              join c in categories
        //             on i.CategoryId equals c.CategoryId
        //             select new
        //             {
        //                 i.ProductName,
        //                 c.CategoryName
        //             };

        //foreach(var item in result)
        //{
        //    Console.WriteLine(item.ProductName+":"+item.CategoryName);
        //}

        //Aggregate_Linq a = new Aggregate_Linq();
        //a.input();


        //List<Project> projects = new List<Project>()
        //{
        //    new Project { ProjectId=101, ProjectName="Website" },
        //    new Project { ProjectId=102, ProjectName="Mobile App" }
        //};
        //List<Department> departments = new List<Department>()
        //{
        //    new Department { DeptId=1, DeptName="IT" },
        //    new Department { DeptId=2, DeptName="HR" },
        //    new Department { DeptId=3, DeptName="Finance" },
        //    new Department { DeptId=4, DeptName="Marketing" }
        //};
        //List<Employee> employees = new List<Employee>()
        //{
        //    new Employee { EmpId=1, Name="Komal", DeptId=1, Salary=50000 },
        //    new Employee { EmpId=2, Name="Ankita", DeptId=2, Salary=60000 },
        //    new Employee { EmpId=3, Name="Rahul", DeptId=1, Salary=55000 },
        //    new Employee { EmpId=4, Name="Amit", DeptId=3, Salary=40000 },
        //};

        //var names = from e in employees
        //            from p in projects
        //            select new { e, p };
        //foreach (var name in names)
        //    Console.WriteLine(name.e.Name + "->" + name.p.ProjectName);


        //var res = from d in departments
        //          join e in employees
        //          on d.DeptId equals e.DeptId into dept
         
        //          select new
        //          {
        //              DepartmentName= d.DeptName,
        //              Employee_name = dept
        //          };

        //foreach (var name in res)
        //{
        //    Console.Write(name.DepartmentName+ ":");
        //    foreach (var g in name.Employee_name)
        //    {
        //        Console.Write(g.Name+",");
        //    }
        //    Console.WriteLine();
        //}


        //var res1 = (from d in departments
        //            join e in employees
        //            on d.DeptId equals e.DeptId into dept
        //            select new
        //            {
        //                departname = d.DeptName,
        //                Totalsalary = dept
        //                              .Where(e=>e.Salary>=50000)
        //                              .Sum(e=>e.Salary)
        //            });
        //foreach (var name in res1)
        //{
        //    Console.WriteLine(name.departname + ":"+name.Totalsalary);
           
        //}

        //var res2 = from d in departments
        //           join e in employees
        //           on d.DeptId equals e.DeptId into dept
        //           select new
        //           {
        //               avg_salary = dept.Average(e => e.Salary),
        //               salary = dept,
        //               employee=dept
        //           };
        //foreach (var name in res2)
        //{
           
        //    Console.WriteLine(name.employee );

        //}

        //FileHandling f=new FileHandling();
        //f.input();
        //f.output();
        //f.writestream();
        //f.readStream();

        StudentData s=new StudentData();
        //s.writeData();
        s.ReadData();
    }
}