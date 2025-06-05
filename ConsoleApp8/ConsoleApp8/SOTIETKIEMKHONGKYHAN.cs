using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class SOTIETKIEMKHONGKYHAN : SOTIETKIEM
    {
        // Con khong tham so
        public SOTIETKIEMKHONGKYHAN() { }
        // co tham so
        public SOTIETKIEMKHONGKYHAN(int cMND, string ten, double soTienGui, DateTime ngayLapSo, double laiSuat)
            : base(cMND, ten, soTienGui, ngayLapSo, laiSuat)
        {
           
        }
        // Nhap
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            base.Xuat();
        }
        // Tinh tien loi
        public override double TinhTienLoi()
        {
            int soThangGui = (DateTime.Now.Year - NgayLapSo.Year) * 12 + DateTime.Now.Month - NgayLapSo.Month;
            return SoTienGui * LaiSuat * soThangGui;
        }
        
    }
}
