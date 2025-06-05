using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuCung
{
    internal class NgoiNha
    {
        // Thuộc tính: Danh sách thú cưng
        private List<Animal> DanhSachThuCung;

       //Contructor
       public NgoiNha()
        {
            DanhSachThuCung = new List<Animal>();
        }
        // Phương thức nhập thú cưng chó
        public void NhapCho()
        {
            Dog dog = new Dog();
            Console.WriteLine("\nNhập thông tin cho chó");
            dog.Nhap();
            DanhSachThuCung.Add(dog);
        }
        // Phương thúc nhập thú cưng cho mèo
        public void NhapMeo()
        {
            Cat meo = new Cat();
            Console.WriteLine("\nNhập thông tin cho mèo: ");
            meo.Nhap();
            DanhSachThuCung.Add(meo);
        }
        // Phương thức xuất danh sách các con thú cưng
        public void XuatDanhSach()
        {
            Console.WriteLine("\nDanh sách các con thú cưng trong nhà: ");
            if (DanhSachThuCung.Count == 0)
            {
                Console.WriteLine("Không có thú cưng nào trong nhà.");
            }
            else
            {
                foreach (var thuCung in DanhSachThuCung)
                {
                    thuCung.Xuat();
                    Console.WriteLine("---------------------------------------------");
                }
            }
        }
        //Phương thức tính tổng tiền ăn của các con thú cưng
        public void TinhTongTienAn()
        {
            double tongTien = 0;
            foreach (var thuCung in DanhSachThuCung)
            {
                tongTien += thuCung.TinhTien();
            }
            Console.WriteLine("\nTổng tiền ăn của các con thú cưng trong nhà: " + Math.Round(tongTien, 2));
        }
               
    }
}

