using System;
using System.Collections.Generic;
using System.Text;

namespace ALL_LATIHAN_OOP.Week_2B
{
    public class FractionalNumber
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get => numerator;
            set
            {
                if (value == 0)
                {
                    throw new Exception("angka tidak boleh 0 atau kosong");
                }
                else
                {
                    numerator = value;
                }
            }
        }
        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                {
                    throw new Exception("angka tidak boleh 0 atau kosong");
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public FractionalNumber Add(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = numerator * f.denominator + f.numerator * denominator;
            result.Denominator = denominator * f.denominator;
            return result;
        }

        public FractionalNumber Subtrack(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = numerator * f.denominator - f.numerator * denominator;
            result.Denominator = denominator * f.denominator;
            return result;
        }

        public FractionalNumber Multiply(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = numerator * f.numerator;
            result.Denominator = denominator * f.denominator;
            return result;
        }
         public FractionalNumber Divide(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = numerator * f.denominator;
            result.Denominator = denominator * f.numerator;
            return result;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
