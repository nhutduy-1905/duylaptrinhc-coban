// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());
        }
    }
}
