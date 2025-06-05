using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract  class Animal
    {
        public string Ten {  get; set; }
        public int Tuoi { get; set; }
        public double CanNang { get; set; }

        // Contructor không tham số
        public Animal() { }
        // Contructor có tham số
        public Animal(string ten, int tuoi, double canNang)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.CanNang = canNang;
        }
        // Phương thúc Nhập thông tin cho Animal
        public virtual void Nhap()
        {
            Console.Write("Nhập tên thú cưng: ");
            Ten = Console.ReadLine();

            Console.Write("Nhập tuổi thú cưng: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập cân nặng của thú cưng (kg): ");
            CanNang = double .Parse(Console.ReadLine());
        }
        // Phương thức xuất thông tin 
        public virtual void Xuat()
        {
            Console.WriteLine($"Tên: {Ten}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Cân Nặng: {CanNang} kg");
        }
        // Phương thức tính tiền 
        public abstract double TinhTien();
    }
}
