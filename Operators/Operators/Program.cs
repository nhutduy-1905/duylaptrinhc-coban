// See https://aka.ms/new-console-template for more information

using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 50;
            Console.WriteLine(x);
            int sum1 = 100 + 100; // 200 
            int sum2 = sum1 + 250; // 450
            int sum3 = sum2 + sum2; // 900
            int z = 12;
            int y = 3;
            
            Console.WriteLine(z / y);
            Console.WriteLine(z * y);
            Console.WriteLine(z - y);
            Console.WriteLine(z + y);
            Console.WriteLine(z % y);
            Console.WriteLine(y++);
            Console.WriteLine(y--);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            // Toán tử gán +=
            int v = 10;
            v += 5;
            Console.WriteLine(v);

            int b = 1;
            b &= 2;
            Console.WriteLine(b);

            int c = 2;
            c ^= 3;
            Console.WriteLine(c);

            // Toán tử so sánh
            int m = 5;
            int n = 10;
            Console.WriteLine(m > n);

            //Tìm giá trị cao nhất 
            Console.WriteLine(Math.Max(10, 1));
            // Tìm giá trị nhỏ nhất
            Console.WriteLine(Math.Min(10, 1));
            // Trả  về cân bậc hai
            Console.WriteLine(Math.Sqrt(64));
            // Trả về giá trị tuyệt đối
            Console.WriteLine(Math.Abs(-4.7));
            //Làm tròn số nguyên gần nhất
            Console.WriteLine(Math.Round(9.98));
        }
    }
}
