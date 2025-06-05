using System.Text;

public class ConsoleApp12
{
    static void HocWhile()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.WriteLine("Mời bạn nhập số: ");
        n = int.Parse(Console.ReadLine());
        int gt = 1;
        int i = 1;
        while (i <= n)
        {
            gt *= i;
            i++;
        }
        Console.WriteLine("{0}! = {1}", n, gt);
        Console.ReadLine();
    }
    static void HocFor()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.WriteLine("Mời bạn nhập số: ");
        n = int.Parse(Console.ReadLine());
        int gt = 1;
        int i;
        for (i = 1; i<=n, i++)
        {
            gt = gt * i;
        }
        Console.WriteLine("{0}! = {1}", n, gt);
        Console.ReadLine();
    }
    static void Main(String[] args)
    {
        HocWhile();
        HocFor();
    }
}