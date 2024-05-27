// See https://aka.ms/new-console-template for more information

// Truyền ngầm định ( tự động) - chuyển đổi loại nhỏ hơn thành kích thước lớn hơn
/* 
 * char - int - long - float - double
*/
using System.Text;

int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);
// Truyền rõ ràng ( thủ công) - chuyển đổi loại lớn hơn thành kích thước nhỏ hơn
/*
 * double - float - long - int - char
*/
double myDouble2 = 9.78;
int myInt2 = (int) myDouble2;

Console.WriteLine(myDouble2);
Console.WriteLine(myInt2);

/* Chuyển đổi các kiểu dữ liệu
 * Convert.ToBoolean
 * Convert.ToDouble
 * Convert.ToString
 * Convert.ToInt32
 * Convert.ToInt64 (long)
 */
int myInt3 = 10;
double myDouble3 = 9.75;
bool myBool1 = true;
string myString1 = "Việt Nam";
Console.WriteLine(Convert.ToString(myInt3));
Console.WriteLine(Convert.ToDouble(myInt3));
Console.WriteLine(Convert.ToInt32(myDouble3));
Console.WriteLine(Convert.ToBoolean(myBool1));
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(Convert.ToString(myString1));
