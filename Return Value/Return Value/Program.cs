// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x)
        {
            return 5 + x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }
    }
}
