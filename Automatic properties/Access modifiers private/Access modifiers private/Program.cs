
// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Car
    {
        private string model = "Mustang";
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}