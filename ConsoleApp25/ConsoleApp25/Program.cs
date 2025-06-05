namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 4;
            Console.WriteLine(" x = " + x);

            x %= y; // x = x + y
            Console.WriteLine(" x = " + x);
            Console.ReadKey();
        }
    }
}
