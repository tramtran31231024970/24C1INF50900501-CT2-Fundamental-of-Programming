// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise03
{
    class baitapchuoi
    {
        public static void Main(string[] args)
        {//bai01();
            bai02();
        }

        static void bai01()
        {
            Console.WriteLine("input the string:");
            string a = Console.ReadLine();
            Console.WriteLine($"The string you entered is: {a}");
        }
        static void bai02()
        {
            Console.WriteLine("input the string:");
            string a = Console.ReadLine();
            int b = 0;
            foreach (char chr in a)
            {
                b += 1;
            }
            Console.WriteLine($"length of the string is : {b}");

        }




    }
}

