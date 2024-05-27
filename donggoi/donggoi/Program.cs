// See https://aka.ms/new-console-template for more information
using System;
namespace oop
{
    class HinhChuNhat
    {
        private int height;
        private int width;

        public HinhChuNhat(int newHeight, int newWidth)
        {
            height = newHeight;
            width = newWidth;
        }

        public int TinhDienTich()
        {
            return height * width;
        }
    }
}

namespace oop
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Thay doi properties (height, width) cua doi tuong thong qua method public
                HinhChuNhat hcn = new HinhChuNhat(10, 5);


                // lay du lieu thong qua method public
                Console.WriteLine("Dien tich cua {0} la: " + hcn.TinhDienTich(), hcn);
                Console.ReadLine();
            }
        }
    }



    