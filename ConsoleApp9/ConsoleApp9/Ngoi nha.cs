using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Ngoi_nha
    {
        private List<Animal> DanhSachThuCung;
        public Ngoi_nha()
        {
            DanhSachThuCung = new List<Animal>();
        }
        // Nhập
        public void NhapCho()
        {
            Dog dog = new Dog();
            Console.WriteLine("\nNhập thông tin cho chó");
            dog.Nhap();
            DanhSachThuCung.Add(dog);
        }
        // Nhập mèo
        public void NhapMeo()
        {
            Cat meo = new Cat();
            Console.WriteLine("\nNhập thông tin mèo");
            meo.Nhap();
            DanhSachThuCung.Add(meo);
        }
        // Phương thức xuất danh sách
        public void XuatDanhSach()
        {
            Console.WriteLine("\nDanh sách thú cưng trong nhà:");
            if (DanhSachThuCung.Count == 0)
            {
                Console.WriteLine("Không có thú cưng nào trong nhà.");
            }
            else
            {
                foreach (var thuCung in DanhSachThuCung)
                {
                    thuCung.Xuat();
                    Console.Write("-----------");
                }
            }
        }
        // tính tổng
        public void TinhTongTienAn()
        {
            double tongTien = 0;
            foreach (var thuCung in DanhSachThuCung)
            {
                tongTien += thuCung.TinhTien();
            }
            Console.WriteLine("\nTổng tiền ăn của thú cưng trong nhà: "+Math.Round(tongTien,2));
        }
    }
}
