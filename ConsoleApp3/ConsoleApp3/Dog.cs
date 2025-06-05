using QuanLyThuCung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuCung
{
    internal class Dog : Animal
    {

        // Thuộc tỉnh riêng của Dog
        public int ChieuCao { get; set; }
        public int ChieuDai { get; set; }

        // Contructor không tham số
        public Dog() : base() { }
        public Dog(string ten, int tuoi, double canNang, int chieuCao, int chieuDai) : base(ten, tuoi, canNang)
        {
            this.ChieuCao =  chieuCao;
            this.ChieuDai = chieuDai;
        }
        // Phương thức nhập cho giá trị Dog
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập chiều cao của chó (cm): ");
            ChieuCao = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chiều dài của chó (cm): ");
            ChieuDai =int.Parse(Console.ReadLine());
        }
        // Phương thức xuất của giá trị Dog
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chiều cao: {ChieuCao} cm");
            Console.WriteLine($"Chiều dài: {ChieuDai} cm");
        }
        // Phương thức tính tiền cho dog

        public override double TinhTien()
        {
            return CanNang * 0.5;
        }
    }
}
