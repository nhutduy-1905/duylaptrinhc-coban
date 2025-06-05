using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuCung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            NgoiNha ngoiNha = new NgoiNha();
            int luaChon;
            do
            {
                Console.WriteLine("\n----MENU QUẢN LÝ THÚ CƯNG");
                Console.WriteLine("1. Nhập thú cưng chó");
                Console.WriteLine("2.Nhập thú cưng mèo");
                Console.WriteLine("3.Xuất danh sách các con thú cưng trong nhà");
                Console.WriteLine("4.Tính tổng tiền ăn của các con thú cưng trong nhà.");
                Console.WriteLine("5.Thoát");
                Console.Write("Chọn chức năng: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        ngoiNha.NhapCho();
                        break;
                    case 2:
                        ngoiNha.NhapMeo();
                        break;
                    case 3:
                        ngoiNha.XuatDanhSach();
                        break;
                    case 4:
                        ngoiNha.TinhTongTienAn();
                        break;
                    case 5:
                        Console.WriteLine("Chương trình kết thúc. Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (luaChon != 5);     

        }
    }
}
