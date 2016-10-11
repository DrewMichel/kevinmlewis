﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab2
{
    class Fraction
    {
        int numerator;
        int denominator;

        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void setDenominator(int denominator)
        {
            this.denominator = denominator;
        }

        public int getNumerator()
        {
            return this.numerator;
        }

        public int getDenominator()
        {
            return this.denominator;
        }

        public double value()
        {
            return this.numerator / (double)this.denominator;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", this.numerator, this.denominator);
        }

        public string reduced()
        {
            return String.Format("{0}/{1}", this.numerator / gcd(), this.denominator/gcd());
        }

        public int gcd()
        {
            int max = numerator;
            if(denominator < max)
            {
                max = denominator;
            }

            int factor = 1;

            for (int i = 2; i <= max;i++)
            {
                if(numerator % i == 0 && denominator %i == 0)
                {
                    factor = i;
                }
            }
            return factor;
        }
    }
}
