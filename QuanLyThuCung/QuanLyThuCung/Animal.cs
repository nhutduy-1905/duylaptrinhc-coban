using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuCung
{
    // Lớp trừu tượng Animal
    abstract class Animal
    {
        // Thuộc tính
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public double CanNang { get; set; }

        // Constructor không tham số
        public Animal() { }

        

        // Constructor có tham số
        public Animal(string ten, int tuoi, double canNang)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.CanNang = canNang;
        }

        // Phương thức Nhập thông tin cho Animal
        public virtual void Nhap()
        {
            Console.Write("Nhập tên thú cưng: ");
            Ten = Console.ReadLine();

            Console.Write("Nhập tuổi của thú cưng: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập cân nặng của thú cưng (kg): ");
            CanNang = double.Parse(Console.ReadLine());
        }

        // Phương thức Xuất thông tin cho Animal đã nhập
        public virtual void Xuat()
        {
            Console.WriteLine($"Tên: {Ten}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Cân nặng: {CanNang} kg");
        }

        // Phương thức trừu tượng TinhTien() để tính tiền ăn cho thú cưng
        public abstract double TinhTien();
    }
}
