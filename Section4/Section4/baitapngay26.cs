using System;

namespace ControlFlowStatements
{
    class baitapngay26_v2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chon bai tap de chay:");
            Console.WriteLine("1. Bai tap 01");
            Console.WriteLine("2. Bai tap 02");
            Console.WriteLine("3. Bai tap 03");
            Console.WriteLine("4. Bai tap 04");
            Console.WriteLine("5. Bai tap 05");
           
        
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    baitap01();
                    break;
                case 2:
                    baitap02();
                    break;
                case 3:
                    baitap03();
                    break;
                case 4:
                    baitap04();
                    break;
                case 5:
                    baitap05();
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }
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
            int[] numbers = new int[10];
            int sum = 0;

            Console.WriteLine("Nhap 10 so nguyen:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            double average = sum / 10.0;

            Console.WriteLine($"Tong cua 10 so la: {sum}");
            Console.WriteLine($"Trung binh cua 10 so la: {average}");
        }

       
    }
}
