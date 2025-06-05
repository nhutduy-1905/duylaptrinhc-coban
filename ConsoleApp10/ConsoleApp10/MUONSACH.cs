using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class MUONSACH : SACH 
    {
        public string MaDocGia {  get; set; }
        public int SoLuong { get; set; }

        public static double PhiCuocMuonTra {  get; set; }

        public MUONSACH() { }
        public MUONSACH(string maSach, string tenSach, string maDocGia, int soLuong, double
            phiCuocMuonTra) : base(maSach, tenSach)
        {
            this.MaDocGia = maDocGia;
            this.SoLuong = soLuong;
            MUONSACH.PhiCuocMuonTra = phiCuocMuonTra;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập vào mã  độc giả: ");
            MaDocGia = Console.ReadLine();
            Console.Write("Nhập số lượng mượn sách: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Mã độc giả là: {MaDocGia}");
            Console.WriteLine($"Số lượng mượn sách: {SoLuong}");
        }
        public  double SoTienCuocMuonTra()
        {
            return SoLuong * PhiCuocMuonTra;
        }
    }
}
