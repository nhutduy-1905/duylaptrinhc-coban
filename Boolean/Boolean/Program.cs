// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            Console.WriteLine(10 > 9);
            int z = 10;
            Console.WriteLine(x == z);
            Console.WriteLine(10 == 15);
            int myAge = 20;
            int votingAge = 19;
            Console.WriteLine(myAge >= votingAge);
            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
        }
    }
}
