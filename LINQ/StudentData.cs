using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQ_CSharp
{
    public class StudentData
    {
       
        public List<Student> ReadData()
        {
            string path = "Student.txt";
            List<Student> students=new List<Student>();
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("File is present");
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split(',');
                            Student s = new Student();
                             s.Ind = int.Parse(data[0]);
                            s.Name = data[1];
                            s.Branch = data[2];
                            s.Grade = data[3];
                            s.Cgpa= double.Parse(data[4]);

                            Console.WriteLine(s.Ind + " " + s.Name + " " + s.Branch + " " + s.Grade + " " + s.Cgpa);

                            students.Add(s);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurs");
            }
            return students;
            
        }
    }
}
