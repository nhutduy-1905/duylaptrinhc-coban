// See https://aka.ms/new-console-template for more information
using System;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
                
        }
    }
}