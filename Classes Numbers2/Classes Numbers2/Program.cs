// See https://aka.ms/new-console-template for more information
/*
using System;
namespace MyApplication
{
    class Car
    {
        string model;
        string color;
        int year;
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 2024;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "blue";
            Opel.year = 2005;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

        }
    }
}
*/
using System;
namespace MyApplication
{
    class Car
    {
        string color; // field
        int maxSpeed; // field
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can");
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();
        }
    }
}

