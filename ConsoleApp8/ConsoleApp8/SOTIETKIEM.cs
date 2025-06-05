using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class SOTIETKIEM
    {
        public int CMND { get; set; }
        public string Ten {  get; set; }
        public double SoTienGui {  get; set; }
        public DateTime NgayLapSo {  get; set; }
        public double LaiSuat {  get; set; }
        
        // Con khong ts
        public SOTIETKIEM() { }
        // Con co ts
        public SOTIETKIEM(int cMND, string ten, double soTienGui, DateTime ngayLapSo, double laiSuat)
        {
            this.CMND = cMND;
            this.Ten = ten;
            this.SoTienGui = soTienGui;
            this.NgayLapSo = ngayLapSo;
            this.LaiSuat = laiSuat;
        }
        // Nhap thong tin
        public virtual void Nhap()
        {
            Console.Write("Nhap vao so CMND: ");
            CMND = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap so tien gui: ");
            SoTienGui = double.Parse(Console.ReadLine());
            Console.Write("Nhap ngay lap so: ");
            NgayLapSo = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap lai suat: ");
            LaiSuat = double.Parse(Console.ReadLine());
        }
        // XUAT
        public virtual void Xuat()
        {
            Console.WriteLine($"CMND: {CMND}");
            Console.WriteLine($"Ten: {Ten}");
            Console.WriteLine($"So tien gui: {SoTienGui}");
            Console.WriteLine($"Ngay lap so: {NgayLapSo}");
            Console.WriteLine($"Lai suat: {LaiSuat}");
        }
        // phuong thuc tinh tien loi
        public abstract double TinhTienLoi();
    }
}
