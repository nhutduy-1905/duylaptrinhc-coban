

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =System.Text.Encoding.UTF8;
              Console.WriteLine("Bạn có 3 lần nhập mật khẩu");
            int attemptCount = 0;
            
           while(true)
           {
              
                Console.Write("Nhập mật khẩu: ");
                int mk;
                bool isValid = Int32.TryParse(Console.ReadLine(), out mk);
                if (!isValid)
                {
                    Console.WriteLine("Vui lòng nhập một số.");
                    continue;
                }
               
                    if (mk == 1234)
                {
                  
                    Console.WriteLine("Nhap dung mat khau");
                    break;
                   
                }
                else
                {
                   
                    attemptCount++;
                 
                    if(attemptCount >=3)
                    {
                        Console.WriteLine("Bạn đã nhập quá ba lần");
                        break;
                    }
                    Console.WriteLine("Ban nhap sai mat khau");
                    Console.WriteLine($"Bạn còn {3 - attemptCount} lần nhập");
                }
            }
            Console.WriteLine("Chương trình kết thúc. Vui lòng thử lại sau.");


        }
    }
}
