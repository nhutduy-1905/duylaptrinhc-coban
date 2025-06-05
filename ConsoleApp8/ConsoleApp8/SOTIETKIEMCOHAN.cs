using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class SOTIETKIEMCOHAN : SOTIETKIEM
    {
        public int KyHan {  get; set; }
        // Con khong tham so
        public SOTIETKIEMCOHAN() { }
        // co tham so
        public SOTIETKIEMCOHAN(int cMND, string ten, double soTienGui, DateTime ngayLapSo, double laiSuat,int kyHan)
            : base(cMND, ten, soTienGui, ngayLapSo, laiSuat)
        {
            this.KyHan = kyHan;
        }
        // Nhap
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ky han: ");
            KyHan = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ky han: {KyHan}");
        }
        // Tinh tien loi
        public override double TinhTienLoi()
        {
            int soThangGui = (DateTime.Now.Year - NgayLapSo.Year) * 12 + DateTime.Now.Month - NgayLapSo.Month;
            if (soThangGui >= KyHan)
            {
                return SoTienGui * LaiSuat * soThangGui;
            }
            else
            {
                return 0;
            }
        }
    }
    
}
