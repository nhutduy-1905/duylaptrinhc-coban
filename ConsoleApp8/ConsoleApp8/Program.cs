using System.Text;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            NganHang nganHang = new NganHang();
            int luaChon;
            do
            {
                Console.WriteLine("\n------MENU QUAN LY SO TIET KIEM --------");
                Console.WriteLine("1.Nhap so tiet kiem co han");
                Console.WriteLine("2.Nhap so tiet kiem khong co han");
                Console.WriteLine("3.Xuat danh sach cac loai so tiet kiem");
                Console.WriteLine("4.Tinh tong tien lai ngan hang phai tra");
                Console.WriteLine("5.Thoat");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        nganHang.NhapSoTietKiemCoHan();
                        break;
                    case 2:
                        nganHang.NhapSoTietKiemKhongCoHan();
                        break;
                    case 3:
                        nganHang.XuatSoTietKiem();
                        break;
                    case 4:
                        nganHang.TinhTongTienLai();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
            while (luaChon != 5);
          
        }
    }
}
