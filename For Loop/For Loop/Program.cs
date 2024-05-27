// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           /* for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/
           for (int i = 1; i <=2; i++)
            {
                Console.WriteLine("Outer:" + i);                          
                for(int j = 1; j <= 3; j++)
                {
                   Console.WriteLine("Inner:" + j);
                }               
            }
        }
    }

}
