using System;
namespace baitapvenha
{
    class Test
    {
        public static void Main(string[] args)
        { baitap_01();
            //baitap_02();
            //baitap_03();
            //baitap_04();
            //baitap_05();
            //baitap_06();
            //baitap_07();
            //baitap_08();
            //baitap_09();
            //baitap_10();
        }
        static void baitap_01()
        {
            int a, b;
            Console.WriteLine("Nhap a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong hai so:{0}", a + b);

        }
        static void baitap_02̣()
        {
            int a, b;
            Console.WriteLine("Nhap a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Truoc khi hoan doi: a={a},b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Sau khi hoan doi a={a}, b={b}");
        }
        static void baitap_03()
        {
            Console.WriteLine("Nhap so a:");
            float number_a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap so b:");
            float number_b = Convert.ToSingle(Console.ReadLine());
            float Multiply = number_a * number_b;
            Console.WriteLine($"{number_a} * {number_b} = {Multiply}");

        }
        static void baitap_04()
        {
            Console.WriteLine("Nhap so voi don vi feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet / 3.2808;
            Console.WriteLine($"Convert feet to meter: {feet} feet = {meter} meter");

        }
        static void baitap_05()
        {
            Console.WriteLine("Nhap nhiet do don vi Celsius");
            double Celsius_1=Convert.ToDouble(Console.ReadLine());
            double Fahrenheit_1 = 1.8 * Celsius_1+32;
            Console.WriteLine($"Convert Celsius to Fahrenheit: {Celsius_1} do C={Fahrenheit_1} do F");
            Console.ReadLine();
            Console.WriteLine("Nhap nhiet do don vi Fahrenheit");
            double Fahrenheit_2 = Convert.ToDouble(Console.ReadLine());
            double Celsius_2 = 5 * (Fahrenheit_2 - 32) / 9;
            Console.WriteLine($"Convert Fahrenheit to Celsius: {Fahrenheit_2}  do F =  {Celsius_2} do C");
        }
       static void baitap_06()
        {
            Console.WriteLine($"Size of int: {sizeof(int)}");
            Console.WriteLine($"Size of float: {sizeof(float)}");
            Console.WriteLine($"Size of char: {sizeof(char)}");
            Console.WriteLine($"Size of double: {sizeof(double)}");
            Console.WriteLine($"size of bool: {sizeof(bool)}");
        }
        static void baitap_07()
        { }
        static void baitap_08()
        {
            Console.WriteLine("Nhap r");
            double r=Convert.ToSingle(Console.ReadLine());
            double S = r * r * 3.14;
                Console.WriteLine($"Dien tich hinh tron: ");
        
        }
        static void baitap_09()
        {
            Console.WriteLine("Nhap canh hinh vuong a=");
            double a=Convert.ToDouble(Console.ReadLine());
            double S = a * a;
            Console.WriteLine($"Dien tich hinh vuong:");
        }
        static void baitap_10()
        {
            Console.WriteLine("Nhap so ngay:");
            int n_days = Convert.ToInt32(Console.ReadLine());
            int year = n_days / 365;
            int week = (n_days % 365) / 7;
            int day = (n_days % 365) % 7;
            Console.WriteLine($"{n_days} ngay tuong duong {year} nam {week} tuan {day} ngay");

        }

    }
}