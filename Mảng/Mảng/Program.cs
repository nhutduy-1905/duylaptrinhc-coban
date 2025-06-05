// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            /*Console.WriteLine(cars[1]);
            // Thay đôiẻ mảng phần tử
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            // Độ dài mảng
            Console.WriteLine(cars.Length);*/
            //Nhiều cách để tạo mảng
           /*
            * string[] cars = new string[4];
            * string[] cars = new string[4];
            * string[] cars = new string[];
            * string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            */
           // lặp qua mảng
           for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
           foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Array.Sort(cars);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach(int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
