using QuanLyThuCung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuCung
{
    internal class Cat : Animal
    {
      // Thuộc tính riêng của Cat
      public string LoaiMeo { get; set; }
      //Contructor không tham số
      public Cat() : base() { }
        // Contructor có tham số
      public Cat(string ten, int tuoi, double canNang, string loaiMeo)
            :base(ten, tuoi, canNang)
        {
            this.LoaiMeo = loaiMeo;
        }
        // Phương thúc nhập giá trị cho cat
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại mèo: ");
            LoaiMeo = Console.ReadLine();
        }
        // Phương thức xuât giá trị của cat
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại mèo: {LoaiMeo}");
        }
        public override double TinhTien()
        {
            return (CanNang - 1) * 0.04;
        }


    }
}
