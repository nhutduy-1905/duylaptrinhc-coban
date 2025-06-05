using System.Text;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Mời bạn nhập vào chiều đài: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời banh nhập vào chiểu rộng: ");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            double p = (a + b) * 2;
            Console.WriteLine("Diện tích hình chữ nhật là: " + s);
            Console.WriteLine("Chu vi hình chữ nhật là: " + p);
        }
    }
}
