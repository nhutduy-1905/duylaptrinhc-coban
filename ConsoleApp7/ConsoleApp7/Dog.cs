﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Dog : Animal
    {
        // Thuộc tính riêng của Dog
        public int ChieuCao { get; set; }
        public int ChieuDai { get; set; }
        // Contructor không tham số
        public Dog() { }
        // Contructor có tham số
        public Dog(string ten, int tuoi, double canNang, int ChieuCao, int ChieuDai)
            : base(ten, tuoi, canNang)
        {
            this.ChieuCao = ChieuCao;
            this.ChieuDai = ChieuDai;
        }
        // Nhập giá trị cho Dog
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập chiều cao của chó (cm): ");
            ChieuCao = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều dài của chó (cm): ");
            ChieuDai = int.Parse(Console.ReadLine());
        }
        // Phương thức xuất giá trị của Dog 
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chiều cao: {ChieuCao} cm");
            Console.WriteLine($"Chiều dài: {ChieuDai} cm");
        }
        // Phương thức tính tiền () cho Dog
        public override double TinhTien()
        {
            return CanNang * 0.05;
        }
    }
}
