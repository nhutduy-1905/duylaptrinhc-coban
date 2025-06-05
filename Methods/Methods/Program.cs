// See https://aka.ms/new-console-template for more information
using System;
namespace Application
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I  just got executed!");
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();

        }        
    }
}
