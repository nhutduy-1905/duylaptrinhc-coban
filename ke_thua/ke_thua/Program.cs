// See https://aka.ms/new-console-template for more information
using System;
namespace oop
{
    class HinhDang
    {
        private void showColor()
        {
            Console.WriteLine("Mau hong");
        }
        public void showType()
        {
            Console.WriteLine("Day la hinh chu nhat");
        }
    }
}
namespace oop
{
    class Program: HinhDang
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.showType();
            //pg.ShowType(); khong the truy cap private method
            Console.ReadLine();
        }
    }
}
