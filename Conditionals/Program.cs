using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = 10;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10");
            //}

            //Single line if
            var number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            Console.ReadLine();
        }
    }
}
