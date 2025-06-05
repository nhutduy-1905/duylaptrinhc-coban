namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soLuong = 0;
            float diemTrungBinh = 8.5f;
            double diemToan = 9.5;
            string name = "Toan";
            byte tuoi;
            int a = 1;
            int b = 2;
            int c = a / b;
            float z2 = (float)a / b;
            Console.WriteLine("Gia tri cua {0} / {1} = {2}", a, b, c);
            Console.WriteLine("Gia tri cua {0} / {1} = {2}", a, b, z2);
            Console.WriteLine("So luong la: {0}", soLuong);
            Console.WriteLine("Diem trung binh la {0}", diemTrungBinh);
            Console.WriteLine("Ten ban la: {0}", name);
            Console.WriteLine("Tuoi ban la: {0}", tuoi = 20);
            Console.ReadKey();
        }
    }
}
