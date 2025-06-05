// See https://aka.ms/new-console-template for more information

/*using System;
namespace Application
{
    class program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }
    }
}
*/
using System;
namespace MyApplication 
{ 
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}
