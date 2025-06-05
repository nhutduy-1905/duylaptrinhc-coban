using System.Text;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            int b = 2;
            Console.WriteLine("Mời bạn nhập vào số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn vừa nhập vào số nguyên a = {0}", a);

            a += 3;
            Console.WriteLine("Kết quả {0}", a);
            a -= 5;
            Console.WriteLine("Kết quả {0}", a);
            a *= 2;
            Console.WriteLine("Kết quả {0}", a);
            //a /= 9;
            //Console.WriteLine("Kết quả {0}", a);
            a %= 5;
            Console.WriteLine("Kết quả {0}", a);
            a -=a*(b + 7);
            Console.WriteLine("Kết quả {0}", a);
        }
    }
}
