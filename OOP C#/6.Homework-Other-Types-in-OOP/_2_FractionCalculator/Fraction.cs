using System;

namespace _2_FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator 
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can not be zero.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            try
            {
                var newNumerator = checked((a.Numerator * b.Denominator) + (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Denominator);
                return new Fraction(newNumerator, newDenominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException("The Addition of two fractions will be out of allowed range for new fraction");
            }
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            try
            {
                var newNumerator = checked((a.Numerator * b.Denominator) - (a.Denominator * b.Numerator));
                var newDenominator = checked(a.Denominator * b.Denominator);

                return new Fraction(newNumerator, newDenominator);
            }
            catch (OverflowException)
            {
                throw new InvalidOperationException("The Substraction of two fractions will be out of allowed range for new fraction");                    
            }
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString();
        }
    }
}
