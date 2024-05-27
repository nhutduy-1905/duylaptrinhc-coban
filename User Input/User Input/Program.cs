// See https://aka.ms/new-console-template for more information
//Console.ReadLine() để lấy dữ liệu đầu vào từ người dùng
// Console.ReaLine() trẻ về string
//Type your usernadLme and press enter
/*
using System;
namespace MyAppplication
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            //Print  the value of variable (userName), Which will display the input value
            Console.WriteLine("Username is:" + userName);
        }
    }
 
}
/*
/*
Console.WriteLine("Enter your name:");    
int name = Console.ReadLine();
Console.WriteLine("Name:" + name);  
Output: Error
*/


using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);
        }
    }
}
