using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào mừng bạn đến với khoa CNTT");

            string name = "Lê Hữu Tình";
            int age = 20;
            bool status = false;
            int new_age = 20;
            string sentence = name;
            int a = 5;
            int b = 10;
            int tong = a + b;
            int hieu = a - b;
            int nhan = a * b;
            int chia = a / b;
            string sanpham = ("Mời bạn  nhập tên sản phẩm: ");
            sanpham = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào số lượng sản phẩm:");
            int soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập đơn giá: ");
            int dongia = int.Parse(Console.ReadLine());
            double tien = soluong * dongia;
            double thuegiatrigiatang = 10 % tien;
            Console.WriteLine("Nhập điểm môn toán: ");
            double toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn lý: ");
            double ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn hóa: ");
            double hoa = double.Parse(Console.ReadLine());
            double dtb = (toan + ly + hoa) / 3;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(status);
            Console.WriteLine(new_age + 10);
            Console.WriteLine(sentence + " " + "Love VanLang Univerity.");
            Console.WriteLine(tong);
            Console.WriteLine(hieu);
            Console.WriteLine(nhan);
            Console.WriteLine(chia);
            Console.WriteLine(sanpham);
            Console.WriteLine(soluong);
            Console.WriteLine(dongia);
            Console.WriteLine(tien);
            Console.WriteLine(thuegiatrigiatang);
            Console.WriteLine("Điểm toán của bạn là: " + toan);
            Console.WriteLine("Điểm lý của của bạn là: " + ly);
            Console.WriteLine("Điểm hóa của bạn là: " + hoa);
            Console.WriteLine("Điểm trung bình ba môn toán lý hóa của bạn là: "+ dtb);
        }
    }
}
