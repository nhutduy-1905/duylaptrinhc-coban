using System.Data;
using System.Text;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            float chieuCao, canNang;
            Console.WriteLine("Mời nhập vào chiều cao (m): ");
            chieuCao = float .Parse(Console.ReadLine());

            Console.WriteLine("Mời nhập vào cân nặng (kg): ");
            canNang = float .Parse(Console.ReadLine());

            // tinh BMI
            double BMI = canNang / (Math.Pow(chieuCao, 2));
            Console.WriteLine("BMI của bạn là: {0} ", Math.Round(BMI,2));
            // xet dieu kien
            if (BMI < 15)
            {
                Console.WriteLine("Thân hình quá gầy");
            }
            else if (BMI >=15 && BMI < 16)
            {
                Console.WriteLine("Thân hình gầy");
            }
            else if (BMI >= 16 && BMI < 18.5)
            {
                Console.WriteLine("Thân hình hơi gầy");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Thân hình bình thường");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Thân hình hơi béo");
            }
            else 
            {
                Console.WriteLine("Thân hình quá béo ");
            }
                Console.ReadKey();

        }
    }
}
