using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Animal
    {
        public string Ten {  get; set; }
        public int Tuoi { get; set; }
        public double CanNang { get; set; }
        // Contructor khong tham so
        public Animal() {  }
        public Animal(string ten, int tuoi, double canNang)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.CanNang = canNang;
        }
        // Nhap
        public virtual void Nhap()
        {
            Console.Write("Nhap ten thu cung: ");
            Ten = Console.ReadLine();

            Console.Write("Nhap tuoi thu cung ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap can nang thu cung (kg)");
            CanNang = double.Parse(Console.ReadLine());
        }
        // Xuat
        public virtual void Xuat()
        {
            Console.WriteLine($"Ten: {Ten}");
            Console.WriteLine($"Tuoi: {Tuoi}");
            Console.WriteLine($"Can Nang: {CanNang}");
        }
        // Phuong thu tinh tien 
        public abstract double TinhTien();

    }
}
