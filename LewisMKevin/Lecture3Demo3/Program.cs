using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo3
{
    class Program
    {
        public const int OVERTIME_HOURS = 40;
        public const double HOURLY_WAGE = 10.00;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of hours worked");
            string hoursWorked = Console.ReadLine();
            int hours = Int32.Parse(hoursWorked);
            double wage = 0;

            if (OVERTIME_HOURS <= hours)
            {
                wage = (OVERTIME_HOURS * HOURLY_WAGE) + ((hours - OVERTIME_HOURS) * HOURLY_WAGE * 1.5);
            }
            else if( hours < 0)
            {
                wage = 0;
            }
            else
            {
                wage = hours * HOURLY_WAGE;
            }

            Console.WriteLine("Weekly wage = {0:c}", wage);
            Console.ReadKey();

        }
    }
}
