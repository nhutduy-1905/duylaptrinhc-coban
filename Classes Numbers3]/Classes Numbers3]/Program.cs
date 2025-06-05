// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 2024;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "yellow";
            Opel.year = 2005;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);              
        }
    }
}
