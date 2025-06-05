<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information

using System.Runtime.Intrinsics.X86;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int a = 5;
a += 2;
Console.WriteLine("a = {0}", a);


// Nhập vào một số, hỏi số đó là chẵn hay lẻ
int b;
Console.WriteLine("Mời bạn nhập vào số b: ");
b = int.Parse(Console.ReadLine());
// Console.ReadLine() ==> chờ người dùng nhập 1 giá trọ rồi nhấn phím enter
// Nếu nhập 5  ==> hiểu là "5" ==> cần đưa "5" về 5
// int.Parse('5')
if (b % 2 == 0)
    Console.WriteLine("{0} là số chẵn", b);
else
    Console.WriteLine("{0} là số lẻ", b);

int year;
Console.WriteLine("Mời bạn nhập vào một năm: ");
year = int.Parse(Console.ReadLine());
// Năm nhuần là năm chia hết cho 4 nhưng không chia hết cho 100
// hoặc chia hết cho 400
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("{0} là năm nhuần", year);
}
else
{
    Console.WriteLine("{0}  không là năm nhuần", year);
}
// Nhập vào 1 điểm, kiểm tra đậu hay rớt
double diem;
Console.WriteLine("Mời bạn nhập vào điểm: ");
diem = double.Parse(Console.ReadLine());
if (!(diem > 5))
{
    Console.WriteLine("Điểm = {0} ==> Rớt",diem);
}
else
{
    Console.WriteLine("Điểm = {0} ==> Đậu", diem);
}

int a1 = 5; int b1 = 8;int c1 = 9;
int z = ++a1 - b++ - --c1 + 2;
Console.WriteLine("a = {0}, b = {1}, c = {2}, z= {3}",a1,b1,c1,z);
Console.ReadLine();
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> e5da0a09be367aabd4762c272c20b63a5e12f3be
