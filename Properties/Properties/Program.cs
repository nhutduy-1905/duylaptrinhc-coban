// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Person
    {
        private string name; // field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }  // property 

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "liam";
            Console.WriteLine(myObj.Name);
        }
    }
}