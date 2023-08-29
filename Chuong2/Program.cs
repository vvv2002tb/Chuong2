using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*max2();
            max3();
            uscln();
            tong();
            us();
            indausao();*/
        }

        static bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        public static void max2()
        {
            int a, b;

            Console.Write("Nhap so nguyen A: ");
            string inputA = Console.ReadLine();
            while (!IsInteger(inputA))
            {
                Console.Write("Khong phai so nguyen. Nhap lai so nguyen A: ");
                inputA = Console.ReadLine();
            }
            a = int.Parse(inputA);

            Console.Write("Nhap so nguyen B: ");
            string inputB = Console.ReadLine();
            while (!IsInteger(inputB))
            {
                Console.Write("Khong phai so nguyen. Nhap lai so nguyen B: ");
                inputB = Console.ReadLine();
            }
            b = int.Parse(inputB);

            int max = Math.Max(a, b);
            Console.WriteLine("Max is {0}", max);
            Console.Read();
        }


        public static void max3()
        {
            double a, b, c;
            Console.Write("Nhap so nguyen A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen C: ");
            c = double.Parse(Console.ReadLine());
            double max = a;
            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("Max is {0}", max);
            Console.Read();
        }


        public static void uscln()
        {
            uint a, b;
            Console.Write("Nhap so nguyen duong A: ");
            a = uint.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen duong B: ");
            b = uint.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
            Console.Read();
        }


        public static void tong() {
            int tong = 0;
            for (int i = 1; i <= 10; i++ )
            {
                tong += i;
            }
            Console.WriteLine(tong);
            Console.Read();

        }

        public static void us()
        {
            Console.Write("Nhap vao 1 so nguyen duong: ");
            uint n = uint.Parse(Console.ReadLine());
            uint answer = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer++;
                }
            }
            Console.WriteLine("Dem Uoc So Cua {0} la {1}", n, answer);
            Console.Read();
        }

        public static void indausao()
        {
            Console.Write("Nhap n: ");
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
