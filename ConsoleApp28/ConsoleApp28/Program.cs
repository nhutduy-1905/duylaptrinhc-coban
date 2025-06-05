using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            double r;
            const  double PI = 3.14;
            Console.WriteLine("Mời bạn nhập bán kính r của đường tròn: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Bấn kính r bạn vừa nhập là {0}", r);

            Console.WriteLine("Chu vi hình tròn");
            double cv = 2 * r * PI;
            Console.WriteLine("Chu vi hình tròn là: {0} ",cv);
            Console.WriteLine("Diện tích hình tròn");
            double dt = PI * (r*r);
            Console.WriteLine("Diện tích hình tròn là: {0} ",dt);
            Console.ReadKey();
            
        }
    }
}
