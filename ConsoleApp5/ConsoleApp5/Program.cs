using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* double diem;
             Console.Write("Mời bạn nhập điểm: ");
             diem = double.Parse(Console.ReadLine());

             //"5.5" ==> 5.5
             if (diem >= 5)
             {
                 Console.WriteLine("Điểm = {0} ==> Đậu ", diem);
             }
             else
             {
                 Console.WriteLine("Điểm = {0} ==> Rớt", diem);

             }
             Console.ReadLine();
            */
            /* Toán tử ba ngôi
            double diem;
            Console.Write("Mời bạn nhập điểm: ");
            diem = double.Parse(Console.ReadLine());
            string ketqua = diem >= 5 ? "Đậu" : "Rớt";
            Console.Write("Điểm = {0} ==> {1}", diem, ketqua);
            Console.ReadLine();
            */
            // Toán tử ba ngôi
            /*
            double diem;
            Console.Write("Mời bạn nhập điểm: ");
            diem = double.Parse(Console.ReadLine());
            string ketqua = diem >= 8 && diem <= 10 ? "Giỏi" :
                         diem >= 6.5 && diem < 8 ? "Khá" :
                         diem >= 5 && diem < 6.5 ? "Trung bình" :
                         diem >= 0 && diem < 5 ? "Yếu" : "Điểm không hợp lệ";
            Console.Write("Điểm = {0} ==> {1}", diem, ketqua);
            */
            /*
             * Cho a, b là 2 số nguyên, kt là 1 ký tự nhập từ bàn phím ( +,- *, /)
             * Nếu nhập kt là phép toán thì tự động tính toán cho a,b 
             */
            // Ví dụ về switch
            //int a, b;
            //char kt;
            //Console.WriteLine("Nhập a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập b: ");
            //b= int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập phép toán ( +, - ,*, /): ");
            //kt = Console.ReadLine()[0];
            //switch (kt)
            //{
            //    case '+':
            //          Console.WriteLine("{0} + {1}  = {2}", a, b, a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine("{0} - {1}  = {2}", a, b, a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine("{0} * {1}  = {2}", a, b, a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine("{0} / {1}  = {2}", a, b, a / b);
            //        break;
            //}


            Console.WriteLine("Mời bạn nhập tháng (1-12): ");
            string kiemtrathang = Console.ReadLine();
            int nam;
            if (kiemtrathang == "2")
            {
                // Nhập năm để kiểm tra 
                Console.Write("Nhập năm để kiểm tra: ");
                nam = int.Parse(Console.ReadLine());

                // Kiểm tra năm nhuận
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    Console.WriteLine($"Tháng 2 năm {nam} có 29 ngày (năm nhuận).");
                }
                else
                {
                    Console.WriteLine($"Tháng 2 năm {nam} có 28 ngày.");
                }
            }
            else
            {
                switch (kiemtrathang)
                {
                    case "1":
                    case "3":
                    case "5":
                    case "7":
                    case "8":
                    case "10":
                    case "12":
                        Console.WriteLine($"Tháng {kiemtrathang} có 31 ngày");
                        break;

                    case "4":
                    case "6":
                    case "9":
                    case "11":
                        Console.WriteLine($"Tháng {kiemtrathang} có 30 ngày");
                        break;
                    default:
                        Console.WriteLine("Số nhập không hợp lệ! Vui lòng nhập tháng 1 đến 12");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
