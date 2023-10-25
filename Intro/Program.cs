using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int term = 10;

            //string information = "İhtiyaç Kredisi";
            //char firstLetter = 'A';

            //Console.WriteLine(information[0]);
            //Console.WriteLine(information[1]);
            //Console.WriteLine(information[2]);
            //Console.WriteLine(information[3]);
            //Console.WriteLine(information[4]);

            //double dollarToday= 27.40;
            //double dollarYestarday = 27.50;

            //if (dollarToday>dollarYestarday)
            //{
            //    Console.WriteLine("UP");
            //}
            //else if (dollarToday<dollarYestarday)
            //{
            //    Console.WriteLine("DOWN");
            //}
            //else 
            //{
            //    Console.WriteLine("EQUAL");
            //}

            //string button1 = "<button>Giriş Yap</button>";
            //string button2 = "<button>Çıkış Yap</button>";

            //bool isLoggedIn = false;
            //if (isLoggedIn)
            //{
            //    Console.WriteLine(button2);
            //}
            //else
            //{
            //    Console.WriteLine(button1);
            //}

            //string[] courses = new string[] { "C#", "Java", "C++", "Python", "JavaScript" };

            //Console.WriteLine("<ul>");
            //foreach (string course in courses)
            //{
            //    Console.WriteLine(course);
            //}
            //Console.WriteLine("</ul>");


            Console.WriteLine("1-8 Arası bir Sayı Giriniz:");
            int sayiGir = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] rastgelesayi = new int[6];

            if (sayiGir>0 && sayiGir<=8)
            {
                for (int j = 0; j < sayiGir; j++)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int a = rnd.Next(1, 50);
                        while (rastgelesayi.Contains(a))
                        {
                            a = rnd.Next(1, 50);
                            if (!rastgelesayi.Contains(a))
                            {
                                break;
                            }
                        }
                        rastgelesayi[i] = a;
                    }
                    Array.Sort(rastgelesayi);
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(rastgelesayi[i] + ",");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("1-8 Arası bir sayı giriniz.");
            }
            Console.ReadLine();
        }
    }
}
