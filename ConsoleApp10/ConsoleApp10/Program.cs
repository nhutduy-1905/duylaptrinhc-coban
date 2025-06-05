using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            THUVIEN thuvien = new THUVIEN();
            int lc;
            do
            {
                Console.WriteLine("\n------MENU QUẢN LÝ THƯ VIỆN----------");
                Console.WriteLine("1.Nhập thông tin sách");
                Console.WriteLine("2.Hiển thị thông tin mượn trả");
                Console.WriteLine("3.Độc giả có cước phí cao nhất.");
                Console.WriteLine("4. Thoát");
                lc = int.Parse(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        thuvien.NhapDanhSach();
                        break;
                    case 2:
                        thuvien.XuatDanhSach();
                        break;
                    case 3:
                        thuvien.TinhDocGiaCoCuocPhiCaoNhat();
                        break;
                    case 4:
                        Console.WriteLine("Chương trình kết thúc");
                        break;
                    default:
                        Console.WriteLine("Nhập sai");
                        break;

                }
            }
            while (lc != 4);
        }
    }
}
