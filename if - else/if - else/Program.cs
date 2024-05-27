// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (20 > 18) ;
            {
                Console.WriteLine("20 is greater than 18");
            }
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            int time = 20;
            if(time < 19)
            {
                Console.WriteLine("Good day.");

            }
            else
            {
                Console.WriteLine("Good evening.");

            }
            int hour = 22;
            if (hour < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            int tim = 20;
            string result = (tim < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }   

    }
}
