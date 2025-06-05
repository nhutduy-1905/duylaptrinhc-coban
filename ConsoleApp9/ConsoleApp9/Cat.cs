using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Cat : Animal
    {
        //Thuộc tính riêng của mèo
        public string LoaiMeo { get; set; }
        // Contructor không tham số
        public Cat() { }
        // Contructor có tham số
        public Cat (string ten, int tuoi, double canNang, string loaiMeo)
            : base(ten, tuoi, canNang)
        {
            this.LoaiMeo = loaiMeo;
        }
        // Nhập
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại mèo: ");
            LoaiMeo = Console.ReadLine();
        }
        // Xuất
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại mèo: {LoaiMeo}");
        }
        // Tính tiền
        public override double TinhTien()
        {
            return (CanNang - 1) * 0.04;
        }
    }
}
