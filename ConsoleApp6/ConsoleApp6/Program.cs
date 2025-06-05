namespace ConsoleApp6
{
    internal class Program
    {
        static void HocDoWhile()
        {
            int n;
            Console.WriteLine("Mời bạn nhập số n: ");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}! = {1}",n, gt);
        }
        static void Main(string[] args)
        {
            HocDoWhile();
        }
    }
}
