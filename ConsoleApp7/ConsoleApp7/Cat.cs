using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Cat : Animal
    {
        // Thuộc tính riêng của mèo
        public string LoaiMeo { get; set; }
        // Contructor không tham số
        public Cat() { }
        // Contructor có tham số
        public Cat(string ten, int tuoi, double canNang, string loaiMeo)
            : base(ten, tuoi, canNang)
        {
            this.LoaiMeo = loaiMeo;
        }
        // Phương thức nhập giá trị cho cat
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại mèo: ");
            LoaiMeo = Console.ReadLine();
        }
        // Phương thức xuất giá trị của cat
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại mèo: {LoaiMeo}");
        }
        // Phương thức TinhTien() cho Cat
        public override double TinhTien()
        {
            return (CanNang - 1) * 0.04;
        }
    }
}
