using System;
namespace Exercises2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Baitap01();
            //Baitap02();
            //Baitap_02();
            //Baitap03();
        }
        static void Baitap01()
        {
            Console.WriteLine("Nhap nhiet do don vi Celsius");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = 1.8 * Celsius + 32;
            double Kelvin = Celsius + 273;
            Console.WriteLine($"Convert Celsius to Fahrenheit: {Celsius} do C={Fahrenheit} do F");
            Console.WriteLine($"Convert Celsius to Kelvin: {Celsius} do C={Kelvin} do K");
        }
        static void Baitap02()
        {
            Console.WriteLine("Nhap ban kinh r=");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double S = 4 * pi * r * r;
            double V = 4 / 3 * pi * r * r * r;
            Console.WriteLine($"S: {S}");
            Console.WriteLine($"V: {V}");
        }
        static void Baitap_02()
        {
            Console.WriteLine("r=");
            float radius = Convert.ToSingle(Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * pi * Math.Pow(radius, 2);
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);
            Console.WriteLine($"S: {surface}");
            Console.WriteLine($"V: {volume}");
        }
        static void Baitap03()
        {
            Console.WriteLine("Nhap so");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int cong = a + b;
            int tru = a - b;
            int nhan = a * b;
            int chia = a / b;
            int laydu = a % b;
            Console.WriteLine($"{cong}");
            Console.WriteLine($"{tru}");
            Console.WriteLine($"{nhan}");
            Console.WriteLine($"{chia}");
            Console.WriteLine($"{laydu}");
        }
    }
}
