using System.Text;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int DoSoi = 100;
            const int DoDong = 0;
            const double PI= 3.14;
            Console.WriteLine("Độ dông của nước là {0}", DoDong);
            Console.WriteLine("Độ sôi của nước là {0}", DoSoi);
            Console.WriteLine("số PI = {0}", PI);
            Console.ReadKey();

        }
    }
}
