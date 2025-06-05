using System.Text;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var y = 113;
            Console.WriteLine("Kiểu dữ liệu của y là {0}", y.GetType().ToString());

        }
    }
}
