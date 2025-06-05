// See https://aka.ms/new-console-template for more information
// Vòng lặp qua các phân tử của mảng
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
