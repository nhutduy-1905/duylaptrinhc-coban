// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Car
    {
        public string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}
