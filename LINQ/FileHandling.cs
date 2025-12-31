using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQ_CSharp
{
    internal class FileHandling
    {
        public void input()
        {
            string path = "student.txt";
            File.WriteAllText(path, "Komal\nCSE\n987654321");
            Console.WriteLine("data is successfully write ");
            File.AppendAllText(path, "Skills\nlanguages");
            Console.WriteLine("Append Successfully");
        }
        public void output()
        {
            string path = "student1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            File.Delete(path);
        }
        public void writestream()
        {
            using (StreamWriter sw=new StreamWriter("log.txt"))
            {
                for(int i=0;i<2;i++)
                {
                    sw.WriteLine("komal");
                }
                Console.WriteLine("Data is write");
            }
        }
        public void readStream()
        {
            try
            {
                using (StreamReader sr = new StreamReader("log.txt"))
                {

                    for (int i = 0; i < 2; i++)
                    {
                        string data = sr.ReadLine();
                        Console.WriteLine(data);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
}
}
