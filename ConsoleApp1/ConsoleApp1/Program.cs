<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information

using System.Text;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int soLuong = 0;
            double diemToan = 9.5;
            int x1 = 1;
            string name = "Lê Hùng Oai";

            // long long = 15; sai

            Console.WriteLine("Điểm toán = {0}", diemToan);
            Console.WriteLine("Name = {0}, điểm = {1}", name, diemToan);

            double d = 1 / 2;
            Console.WriteLine("d= {0} / {1} = {2}", 1, 2, d);
            double d2 = (double)1/ 2;
            Console.WriteLine("d= {0} / {1} = {2}", 1, 2, d2);
            double d3 = 1.0 / 2;
            Console.WriteLine("d= {0} / {1} = {2}", 1, 2, d3);

            var t = 5;
            Console.WriteLine("Kiểu của t = {0}",t.GetType().ToString());

            const double PI = 3.14;

            int x = 5 + 3;
            Console.WriteLine(x);
            int x2 = (5 + 3) * (4 - 2) / 6;
            Console.WriteLine(x2);

            Console.ReadKey();
        }
    }
}
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> e5da0a09be367aabd4762c272c20b63a5e12f3be
