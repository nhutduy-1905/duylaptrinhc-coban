using System.Runtime.CompilerServices;

namespace Baitap2ThiThu
{
     abstract class Animal
    {
        // Thuộc tính mặc định
        public string ten { get; set; }
        public int tuoi { get; set; }
        public double canNang { get; set; }

        // Controctor không tham số
        public Animal() { }

        // Controctor có tham số
        public Animal(string ten, int tuoi, double canNang)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.canNang = canNang;
        }
        // Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập tên thú cưng: ");
            ten = Console.ReadLine();
            Console.Write("Nhập tuổi thú cưng: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng  thú cưng: ");
            canNang =  double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Tuổi: {tuoi}");
            Console.WriteLine($"Cân nặng: {canNang} kg");
        }
        // Phương thức trừu tượng tính tiền
        public abstract double TinhTien();
    }
    class Dog : Animal
    {
        // Thuộc tính 
        public int ChieuCao { get; set; }

        public int ChieuDai { get; set; }

        public Dog() : base();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
