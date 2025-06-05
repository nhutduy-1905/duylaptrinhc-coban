using System.Text;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bạn nhấn một phím bất kỳ: ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey();

            Console.WriteLine($"\nPhím bạn nhấn: {KeyInfo}"); 
            Console.WriteLine($"\nKý tự tương ứng: {KeyInfo.Key}");
            Console.WriteLine($"\nPhím đặc biệt kèm theo: {KeyInfo.Modifiers}");

        }
    }
}
