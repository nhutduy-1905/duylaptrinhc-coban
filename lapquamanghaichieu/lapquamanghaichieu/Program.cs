// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
