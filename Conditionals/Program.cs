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
            //var number = 11;
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            //Console.ReadLine();

            //Else if
            //var number = 11;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number==20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            //Switch
            var number =11;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            Console.ReadLine();
        }
    }
}
