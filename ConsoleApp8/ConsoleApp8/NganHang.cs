using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class NganHang
    {
        private List<SOTIETKIEM> DanhSachSoTietKiem;
        public NganHang()
        {
            DanhSachSoTietKiem = new List<SOTIETKIEM>();
        }
        // Nhập stk có hạn
        public void NhapSTKCoHan()
        {
            SOTIETKIEMCOHAN stkcohan = new SOTIETKIEMCOHAN();
            Console.WriteLine("\nNhập thông tin cho số tiết kiệm có hạn.");
            stkcohan.Nhap();
            DanhSachSoTietKiem.Add(stkcohan);
        }
        // Phương thúc nhập stk không hạn
        public void NhapSoTietKiemKhongHan()
        {
            SOTIETKIEMKHONGKYHAN stkkhongcohan = new SOTIETKIEMKHONGKYHAN();
            Console.WriteLine("\nNhập thông tin cho số tiết kiệm có hạn.");
            stkkhongcohan.Nhap();
            DanhSachSoTietKiem.Add(stkkhongcohan);
        }
        // Xuat
        public void XuatDanhSach()
        {
            Console.WriteLine("\nDanh sách số tiết kiệm: ");
            if(DanhSachSoTietKiem.Count == 0)
            {
                Console.WriteLine("Không có sổ tiết kiệm.");
            }
            else
            {
                foreach(var stk in DanhSachSoTietKiem)
                {
                    stk.Xuat();
                    Console.WriteLine("------------");
                }
            }
        }
        // Phương thức tính tiền lãi
        public void TinhTongTienLai()
        {
            double tongTien = 0;
            foreach (var stk in DanhSachSoTietKiem)
            {
                tongTien += stk.TinhTienLoi();
            }
            Console.WriteLine("\nTong tien lai cua nagn hang: "+ Math.Round(tongTien,2));
        }
    }
}
