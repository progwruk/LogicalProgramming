using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class DayOfWeek
    {
        int m, d, y, y1, m1, x, d1;
        public void Day()
        {
            Console.WriteLine("Enter the month");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            y = Convert.ToInt32(Console.ReadLine());
            y1 = y - (14 - m) / 12;
            x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = m + 12 * ((14 - m) / 12) - 2;
            d1 = (d + x + 31 * m1 / 12) % 7;
            Console.WriteLine(d1);
            switch (d1)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("No such day");
                    break;
            }
        }
    }
}
