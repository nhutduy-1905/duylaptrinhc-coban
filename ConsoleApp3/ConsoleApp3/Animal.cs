using System.Text;

namespace QuanLyThuCung
{
    // Lớp trừu tượng
    abstract class Animal
    {
        // Thuộc tính
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public double CanNang { get; set; }

        // Contructor không tham số
        public Animal() { }

        // Controctor có tham số
        public Animal(string ten, int tuoi, double canNang)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.CanNang = canNang;
        }
        // Phương thức nhập thông tin cho Animal
        public virtual void Nhap()
        {
            Console.Write("Nhập tên thú cưng:");
            Ten = Console.ReadLine();

            Console.Write("Nhập tuổi của thú cưng: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập cân nặng của thú cưng: ");
            CanNang = double.Parse(Console.ReadLine());
        }
        // Phương thức xuất thông tin cho Animal đã nhập
        public virtual void Xuat()
        {
            Console.WriteLine($"Tên: {Ten}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Cân nặng : {CanNang} kg");
        }
        // Phương thức trừu tượng TinhTien() để tính tiền ăn cho thú cưng
        public abstract double TinhTien();
    }
}

    
     
   