using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    class Employee
    {
        public int EmpId {  get; set; } 
        public string Name { get; set; }
        public int Salary {  get; set; }
        public int DeptId {  get; set; }

    }
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    
    internal class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

}
}
