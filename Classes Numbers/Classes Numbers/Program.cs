// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Car
    {
        string color = "Red";
        int maxSpeed = 200;
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}