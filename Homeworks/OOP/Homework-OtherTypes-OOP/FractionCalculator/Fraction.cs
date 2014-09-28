namespace FractionCalculator
{
    using System;
    using System.Numerics;
    struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator; 

        public BigInteger Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public BigInteger Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0!");
                }
                this.denominator = value;
            }
        }

        public Fraction(BigInteger numerator, BigInteger denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public override string ToString()
        {
            double fractionResult = (double)this.Numerator / (double)this.Denominator;
            return string.Format("{0}", fractionResult);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            BigInteger num = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
            BigInteger denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            BigInteger num = f1.numerator * f2.denominator - f1.denominator * f2.numerator;
            BigInteger denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }
    }
}
