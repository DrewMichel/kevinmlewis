﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date();

            birthday.setMonth(1);
            birthday.setDay(12);
            birthday.setYear(1995);

            Console.WriteLine(birthday.dateString());

            Date midterm = new Date();
            midterm.setMonth(10);
            midterm.setDay(10);
            midterm.setYear(2016);

            Console.WriteLine(midterm.dateString());

            Date final = new Date();
            final.setDate(12, 12, 2016);
            Console.WriteLine(final);

            Console.ReadKey();
        }
    }
}
