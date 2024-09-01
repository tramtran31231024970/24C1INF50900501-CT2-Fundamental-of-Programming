using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControlFlowStatements01
{
    class baitapngay28
    {
        public static void Main(string[] args)
        {
            //baitap01(); //1.Write a C# Sharp program to check whether a given number is even or odd.
            //baitap02();//2.Write a C# Sharp program to find the largest of three numbers.
            //baitap03();//3.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            //baitap04();//4.Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            //baitap05();//5.Write a program to read 10 numbers and find their average and sum.
            //baitap06();//6.Write a program to display the multiplication table of a given integer.
            //baitap07();//7.Write a program to display a pattern like triangles with a number.
            baitap0801();//8.
            //baitap0802
            //baitap0803
            //baitap09();//9.Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5... 1/n terms
            //baitap10();//10.Write a program to find the ‘perfect’ numbers within a given number range.
            //baitap11();//11.Write a program to determine whether a given number is prime or not.
        }





        static void baitap01()
        {
            Console.WriteLine("Nhap so: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else
            {
                Console.WriteLine($"{a} la so le");
            }
        }

        static void baitap02()
        {
            int a, b, c;
            Console.WriteLine("Nhap so thu nhat");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba");
            c = Convert.ToInt32(Console.ReadLine());
            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Vay so lon nhat trong 3 so {a}, {b}, {c} la: " + max);
        }

        static void baitap03()
        {
            double a, b;
            Console.WriteLine("Nhap toa do thu nhat");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap toa do thu hai");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu nhat");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu hai");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu ba");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu tu");
            }
            else
            {
                Console.WriteLine($"Toa do ({a}:{b}) nam tren mot trong cac truc toa do");
            }
        }

        static void baitap04()
        {
            double a, b, c;
            Console.WriteLine("Nhap canh thu nhat cua tam giac");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh thu hai cua tam giac");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh thu ba cua tam giac");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac deu");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac can");
                }
                else
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap khong tao thanh mot tam giac");
            }
        }

        static void baitap05()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10;
            Console.WriteLine($"Tong: {sum}");
            Console.WriteLine($"Trung bình: {average}");
        }
        static void baitap06()
        {
            Console.WriteLine("Nhap so:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            { Console.WriteLine($"{num}.{i}={num * i}"); }
        }
        static void baitap07()
        {
            string userInput;
            int n;
            userInput = Console.ReadLine();
            //Convert to interger
            n = Convert.ToInt32(userInput);
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= i; ++j)
                    Console.Write($"{n}");
                Console.WriteLine("");
            }
        }
        static void baitap0801()
        {
            Console.WriteLine("Nhap so dong: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{j} ");
                Console.Write("\n");
            }
        static void baitap0802()
            {
                int b = 1;
                Console.WriteLine("Nhap so dong: ");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{b} ");
                        ++b;
                    }
                    Console.Write($"\n");
                }
        static void baitap0803()
                {
                    int b = 1;
                    int c;
                    Console.WriteLine("Nhap so dong: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= a; i++)
                    {
                        for (c = 1; c <= a - i; c++) Console.Write(" ");
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{b} ");
                            ++b;
                        }
                        Console.Write($"\n");
                    }
        static void baitap09()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            { sum += 1.0 / i; }
            Console.WriteLine($"{sum}");
        }
        static void baitap10()
        {
            Console.Write("Nhap so bat dau: ");
            int start = int.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc: ");
            int end = int.ToInt32(Console.ReadLine());
            Console.WriteLine("So hoan hao");
            for (int num = start; num <= end; num++)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    { sum += i; }
                }
                if (sum == num)
                { Console.WriteLine(num); }
            }
        }
        static void baitap11()
        {
             int a = 0;
             Console.WriteLine("Nhap so nguyen duong n: ");
             int n = Convert.ToInt32(Console.ReadLine());
             for (int i = 2; i <= n / 2; i++)
             {
              if (n % i == 0)
              {a++;Console.WriteLine($"{n} khong phai so nguyen to");
              break;}
             }
             if (a == 0 && n != 1) Console.WriteLine($"{n} la so nguyen to");
        }
        

    }
}

