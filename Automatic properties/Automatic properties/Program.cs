// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Person
    {
        public string Name
        { get; set; }     
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Hoang Nguyen";
            Console.WriteLine(myObj.Name);
        }
    }
}
