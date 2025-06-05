using System.Text;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Mời nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn vừa nhập vào số {0}",n);
            if (n % 2 != 0)
                Console.WriteLine("Số {0} là số lẻ", n);
            else
                Console.WriteLine("Số {0} là số chẵn", n);
            Console.ReadKey();
        }
    }
}
