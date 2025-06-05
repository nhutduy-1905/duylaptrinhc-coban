using System.Text;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding= Encoding.UTF8;

            Console.Write("Nhập vào tên của bạn: ");
            string name = Console.ReadLine();
            Console.Write("Điểm toán của bạn là: ");
            double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào điểm văn của bạn: ");
            double diemVan = double.Parse(Console.ReadLine());

            Console.WriteLine("Tên của bạn là: {0} ", name);
            Console.WriteLine("Điểm toán của bạn là: {0}", diemToan);
            Console.WriteLine("Điểm văn của  bạn là: {0} ", diemVan);

            //c2
            string name2;
            float diemToan2;
            float diemVan2;
            Console.WriteLine("Mời bạn nhập vào họ tên: ");
            name2 = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào điểm toán");
            diemToan2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào điểm văn");
            diemVan2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Tên của bạn là {0}, điểm toán của bạn là {1}, điểm văn của bạn là {2}", name2, diemToan2, diemVan2);
            Console.ReadKey();

            
        }
    }
}
