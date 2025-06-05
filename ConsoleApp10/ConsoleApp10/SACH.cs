using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class SACH
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }

        public SACH() { }
        public SACH(string maSach, string tenSach)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
        }
        // Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập vào mã sách: ");
            MaSach = Console.ReadLine();
            Console.Write("Nhập vào tên sách: ");
            TenSach = Console.ReadLine();

        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Mã sách là: {MaSach}");
            Console.WriteLine($"Tên sách là: {TenSach}");
        }
    }
}
