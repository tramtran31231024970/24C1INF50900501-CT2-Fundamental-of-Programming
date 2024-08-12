using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02
{
    internal class Exercises
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Nhap a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhap b ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Tong hai so {0} va {1} la: {2}", a, b, a + b);

        }
        
     }       
}