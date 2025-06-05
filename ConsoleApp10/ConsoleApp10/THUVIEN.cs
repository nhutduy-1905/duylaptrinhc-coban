using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class THUVIEN
    {
        private List<SACH> danhSachMuonTra;
        public THUVIEN()
        {
            danhSachMuonTra = new List<SACH>();
        }
        public void NhapDanhSach()
        {
            SACH sach = new SACH();
            Console.WriteLine("\n Nhập thông tin");
            sach.Nhap();
            danhSachMuonTra.Add(sach);
        }
        // Xuất
        public void XuatDanhSach()
        {
            Console.WriteLine("\n Danh sách sách trong thư viện: ");
            if (danhSachMuonTra.Count == 0)
            {
                Console.WriteLine("Không có sách nào được mượn.");
            }
            else
            {
                foreach (var sl in danhSachMuonTra)
                {
                    sl.Xuat();
                    Console.WriteLine("--------------");
                }
            }
        }
        public void TinhDocGiaCoCuocPhiCaoNhat()
        {
            if (danhSachMuonTra.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu mượn trả.")
                return;
            }
            double maxCuoc = 0;
            List<string> docGiaCaoNhat = new List<string>();
            // Tìm cước mượn trả cao nhất
            foreach (SACH sach in danhSachMuonTra)
            {
                double cuoc = sach.TinhCuoc();
                if (cuoc > maxCuoc)
                {
                    maxCuoc = cuoc;
                    docGiaCaoNhat.Clear();
                    docGiaCaoNhat.Add(sach.MaDocGia);
                }
                else if (cuoc == maxCuoc)
                {
                    docGiaCaoNhat.Add(sach.MaDocGia);
                }
                Console.WriteLine("Mã độc giả có số tiền cước mượn trả cao nhất:");
                foreach (string maDocGia in docGiaCaoNhat)
                {
                    Console.WriteLine(maDocGia);
                }
            }
        }
      
    }
}
