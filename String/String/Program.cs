// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            Console.WriteLine(greeting);
            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting2);
            // Độ dài chuỗi length
            string txt = "ABCDEXDHHFJFĐKJDIFOFJFF";
            Console.WriteLine("The length of the txt string is:" + txt.Length);
            // Hoa
            Console.WriteLine(greeting2.ToUpper());
            // Thường
            Console.WriteLine(greeting2.ToLower());

            // Nối chuỗi 
            string firstName = "Phan Hoàng";
            string  lastName = "Nguyên";
            string name = firstName + lastName;
            string name1 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine(name1);

            // string.concat() dùng này nối chuỗi
            string TreeName = "Phan Hoàng";
            string lasName = " Nguyên";
            string names = string.Concat(TreeName, lasName);
            Console.WriteLine(names);

            string x = "20";
            string y = "10";
            string z = x + y;
            Console.WriteLine(z);

            Console.OutputEncoding = Encoding.UTF8;
            string myString = "Phan Hoàng Nguyên";
            Console.WriteLine(myString[0]);
            // Tìm vị Trí chỉ mục
            Console.WriteLine(myString.IndexOf("H"));

            // Substring() bắt đầu từu vị trí, chỉ mục và trả về một chuỗi mới
            string name4 = "Phan Hoàng Nguyên";
            int charPos = name.IndexOf("H");
            string name3 = name4.Substring(charPos);
            Console.WriteLine(name3);

            // Ký tự đặc biệt 
            string Text = "We are the so - called \"Viking\"from the north";
            Console.WriteLine(Text);
            string Txt = "It's alright";
            Console.WriteLine(Txt);
            // Chèn dấu gạch vào một chuỗi
            string Text5 = "The character \\ is called backslash.";
            Console.WriteLine(Text5);
        }
    }
}