namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        /// Hàm này dùng tính toán abc
        /// </summary>
        /// <param name="x">Nhap x kiểu int</param>
        /// <param name="y">Nhap y kieu int</param>
       
        static void Ham1(int x, int y)
        {
           
        }
        static int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            // Đây là biến a, dùng để lưu giá trị kiểu nguyên
            int a = 5;
            /*
             * Người sủa: Huỳnh Nhựt Duy
             * Ngày sửa: 19-11-2024
             * Lý do bổ sung biến b, khởi tạo b = 8 để làm abc
             */
            Ham1(4, 5);
            int t = 4 + 5 + 6;
            int b = 8;
            Console.WriteLine($"a = {a}");
        }
    }
}
