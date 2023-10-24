using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Cemal";
            students[2] = "İdil";

            string[] students3 = new string[3] { "Engin", "Cemal", "İdil" };

            string[] students2 = { "Engin", "Cemal", "İdil" };
            students2[3] = "Ahmet";//Çalışmaz
           

            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
