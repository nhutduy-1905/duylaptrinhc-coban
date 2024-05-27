// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(5, 3));
        }
    }
}
/*
using System;
namespace Application
{
    class Program
    {
      static int MyMethod(int x, int y)
      {
           return x + y;
      }
      static void Main(string[] args)
      {
         Console.WriteLine(MyMethid(5, 3));
      }
    }
}
*/
