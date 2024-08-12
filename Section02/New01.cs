    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section02
{
    internal class New01
    { public static void Main1(string[] args)
        {
            var name = "Mark";
            var date = DateTime.Now;
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.",name, date.DayOfWeek, date);
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}," + $"it's{date:HH:mm}now.");
        }
    }
}
