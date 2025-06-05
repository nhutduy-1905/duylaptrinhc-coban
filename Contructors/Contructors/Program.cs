// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;
namespace MyApplication
{
    class Car
    {
        public string model;
        public Car(string modelName)
        {
            model = modelName;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}

class Car
{
    public string model;
    public string color;
    public int year;

    public Car(String modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 2025);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}
