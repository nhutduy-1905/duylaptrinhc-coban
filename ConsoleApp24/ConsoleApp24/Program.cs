using System.Text;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            float x, y;
            int i1 = 2;
            int i2 = 2;
            int i3 = -3;
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = -0.5f;
       

            Console.WriteLine("Người dùng nhập vào x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Người dùng nhập vào y:");
            y = float.Parse(Console.ReadLine());

            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;
            float z6 = (float)i1 +(i2*i3);
            float z7 = (float)i1 * (i2+i3);
            float z8 = (float)i1 / (i2+i3);
            float z9 = (float)i1 / i2+i3;
            float z10 = (float) 3 + 4 + 5 /3;
            float z11 = (float)(3 + 4 + 5) /3;
            float z12 = d1 + (d2 * d3);
            float z13 = d1 + d2 * d3;
            float z14 = d1 / d2 - d3;
            float z15 = d1 / (d2-d3);
            float z16 = d1 + d2 + d3 /3;
            float z17 = (d1 + d2 + d3) /3;
            float z18 = d1 + d2 + (d3 /3);
            float z19 = 3* (d1 + d2) * (d1 -d3);


            Console.WriteLine("{0} + {1} = {2}", x,y,z1);
            Console.WriteLine("{0} - {1} = {2}", x,y,z2);
            Console.WriteLine("{0} * {1} = {2}", x,y,z3);
            Console.WriteLine("{0} / {1} = {2}", x,y,z4);
            Console.WriteLine("{0} % {1} = {2}", x,y,z5);

            Console.WriteLine("{0} + ({1} * {2}) = {3}", i1,i2, i3,z6);
            Console.WriteLine("{0} * ({1} + {2}) = {3}", i1, i2, i3, z7);
            Console.WriteLine("{0} / ({1} + {2}) = {3}", i1, i2, i3, z8);

            Console.WriteLine("{0} / {1} + {2} = {3}", i1, i2, i3, z9);
            Console.WriteLine("3 + 4 + 5 / 3 = {0}", z10);
            Console.WriteLine("(3 + 4 + 5) / 3 = {0}", z11);

            Console.WriteLine("{0} + ({1} * {2}) = {3}", d1, d2, d3,z12);
            Console.WriteLine("{0} + {1} * {2} = {3}", d1,d2, d3,z13);
            Console.WriteLine("{0} / {1} - {2} = {3}", d1, d2, d3, z14);

            Console.WriteLine("{0} / ({1} - {2}) = {3}", d1, d2, d3, z15);
            Console.WriteLine("{0} + {1} + {2} /3 = {3}", d1, d2, d3, z16);
            Console.WriteLine("({0} + {1} + {2}) /3 = {3}", d1, d2, d3, z17);
            Console.WriteLine("{0} + {1} + ({2} /3) = {3}", d1, d2, d3, z18);
            Console.WriteLine(" 3 * ({0} + {1}) * ({2} - {3})= {4}", d1, d1, d2, d3, z19);
            Console.ReadKey();

            
        }
    }
}
