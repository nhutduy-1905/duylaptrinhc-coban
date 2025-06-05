<<<<<<< HEAD
﻿using System;
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

        // Constructor không tham số
        public Cat() : base() { }

        // Constructor có tham số
        public Cat(string ten, int tuoi, double canNang, string loaiMeo)
            : base(ten, tuoi, canNang)
        {
            this.LoaiMeo = loaiMeo;
        }

        // Phương thức Nhập giá trị cho Cat
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại mèo: ");
            LoaiMeo = Console.ReadLine();
        }

        // Phương thức Xuất giá trị của Cat
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
=======
﻿using System;
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

        // Constructor không tham số
        public Cat() : base() { }

        // Constructor có tham số
        public Cat(string ten, int tuoi, double canNang, string loaiMeo)
            : base(ten, tuoi, canNang)
        {
            this.LoaiMeo = loaiMeo;
        }

        // Phương thức Nhập giá trị cho Cat
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại mèo: ");
            LoaiMeo = Console.ReadLine();
        }

        // Phương thức Xuất giá trị của Cat
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
>>>>>>> e5da0a09be367aabd4762c272c20b63a5e12f3be
