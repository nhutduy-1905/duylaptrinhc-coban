// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Car 
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myObj = new Car();
            // Tao nhieu doi tuong 
            Car myObj2 = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj2.color);
        }
    }

}
/*
class Car
{
    public string color = "red";
}
class Program
{
    static void Main(string[] args)
    {
        Car myObj3 = new Car();
        Console.WriteLine(myObj3.color);
    }
}
*/