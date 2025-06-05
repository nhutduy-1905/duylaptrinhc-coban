// See https://aka.ms/new-console-template for more information
using System;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                /*Console.WriteLine(i);
                i++;
                if( i == 4)
                {
                    break;
                }*/
                if (i == 4)
                {
                    i++;
                    continue;

                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
