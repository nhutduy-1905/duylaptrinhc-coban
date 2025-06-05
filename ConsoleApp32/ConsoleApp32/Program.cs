using System.Text;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tổng hai số: ");
            double tong  = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hiệu hai số: ");
            double hieu = double.Parse(Console.ReadLine());
            double x = (tong + hieu) / 2;
            double y = (tong - hieu) / 2;
            
            Console.WriteLine($"Gía  trị của x cần tìm là x = {x} ");
            Console.WriteLine($"Gía tri cua y cần tìm là: y = {y} ");
        }
    }
}
