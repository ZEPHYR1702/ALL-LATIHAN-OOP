using System;
using System.Collections.Generic;
using System.Text;

//KEFFKA_160425072
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
            result.Numerator = this.Numerator * f.Denominator + f.Numerator * this.Denominator;
            result.Denominator = this.Denominator * f.Denominator;
            return result;
        }
        public static FractionalNumber Add(FractionalNumber f1, FractionalNumber f2)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }

        public FractionalNumber Add(int f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator + f * this.Denominator;
            result.Denominator = this.Denominator;
            return result;
        }

        public FractionalNumber Subtrack(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator * f.Denominator - f.Numerator * this.Denominator;
            result.Denominator = this.Denominator * f.Denominator;
            return result;
        }
        public static FractionalNumber Subtrack(FractionalNumber f1, FractionalNumber f2)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }
        public FractionalNumber Subtrack(int f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator - f * this.Denominator;
            result.Denominator = this.Denominator;
            return result;
        }

        public FractionalNumber Multiply(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator * f.Numerator;
            result.Denominator = this.Denominator * f.Denominator;
            return result;
        }
        public static FractionalNumber Multiply(FractionalNumber f1, FractionalNumber f2)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = f1.Numerator * f2.Numerator;
            result.Denominator = f1.Denominator * f2.Denominator;
            return result;
        }
        public FractionalNumber Multiply(int f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator * f;
            result.Denominator = this.denominator;
            return result;
        }
        public FractionalNumber Divide(FractionalNumber f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator * f.Denominator;
            result.Denominator = this.Denominator * f.Numerator;
            return result;
        }
        public static FractionalNumber Divide(FractionalNumber f1, FractionalNumber f2)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = f1.Numerator * f2.Denominator;
            result.Denominator = f1.Denominator * f2.Numerator;
            return result;
        }
        public FractionalNumber Divide(int f)
        {
            FractionalNumber result = new FractionalNumber();
            result.Numerator = this.Numerator;
            result.Denominator = this.Denominator * f;
            return result;
        }

        public void Simplify()
        {
            FractionalNumber result = new FractionalNumber();
            int gcd = GCD(this.Numerator, this.Denominator);
            result.Numerator = this.Numerator / gcd;
            result.Denominator = this.Denominator / gcd;
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public string Display()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }
        public static FractionalNumber operator +(FractionalNumber f1, FractionalNumber f2)
        {
            return Add(f1, f2);
        }
        public static FractionalNumber operator -(FractionalNumber f1, FractionalNumber f2)
        {
            return Subtrack(f1, f2);
        }
        public static FractionalNumber operator *(FractionalNumber f1, FractionalNumber f2)
        {
            return Multiply(f1, f2);
        }
        public static FractionalNumber operator /(FractionalNumber f1, FractionalNumber f2)
        {
            return Divide(f1, f2);
        }
    }
}
