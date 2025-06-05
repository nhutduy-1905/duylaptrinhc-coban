using System.Text;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            float diemTN;
            Console.WriteLine("Mời bạn nhập vào điểm tốt nghiệp: ");
            diemTN = float.Parse(Console.ReadLine());
            if (diemTN >= 8.0)
                Console.WriteLine("Điểm tốt nghiệp của bạn là {0}, đạt loại giỏi", diemTN);
            else if (diemTN < 8 && diemTN >= 6.5)
                Console.WriteLine("Điểm tốt nghiệp của bạn là {0}, đạt loại khá", diemTN);
            else if (diemTN < 6.5 && diemTN >= 5)
                Console.WriteLine("Điểm tốt nghiệp của bạn là {0}, đạt loại trung bình", diemTN);
            else
                Console.WriteLine("Điểm tốt nghiệp của bạn là {0}, đạt loại yếu", diemTN);
            Console.ReadKey();
        }
    }
}
