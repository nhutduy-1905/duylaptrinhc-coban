// See https://aka.ms/new-console-template for more information
using System;
namespace oop
{
    class HinhDang
    {
        public void showType()
        {
            Console.WriteLine("Day la hinh chu nhat");
        }
    }
}
namespace oop
{
    class MauSac : HinhDang
    {
        public void showColor()
        {
            Console.WriteLine("Mau hong");
        }
    }
}
namespace oop
{
    class Program : MauSac 
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.showType();
            pg.showColor();
            Console.ReadLine();
        }
    }
}
