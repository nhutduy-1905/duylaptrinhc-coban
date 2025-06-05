// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // switch câu lệnh chọn một khối lệnh thực thi
            // giá trị của biểu thức so sánh vs giá trị của mõi biểu thức case
            int days = 5;
            switch (days)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forrward  to the Weekend");
                    break;
              // default chỉ định chạy nếu ko có trường hợp nào
            } 

        }
    }

}
