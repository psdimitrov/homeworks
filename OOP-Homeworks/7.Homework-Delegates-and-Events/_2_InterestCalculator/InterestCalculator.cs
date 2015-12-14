using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InterestCalculator
{
    public delegate double CalculateInterest(double money, double interest, int years);

    class InterestCalculator
    {
        private CalculateInterest interestCalcDelegate;
        private double money;
        private double interest;
        private int years;

        public InterestCalculator(double money, double interest, int years, CalculateInterest interestCalcDelegate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.interestCalcDelegate = interestCalcDelegate;
        }

        private double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money can not be negative");
                }
                this.money = value;
            }
        }

        private double Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest can not be negative");
                }
                this.interest = value;
            }
        }

        private int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years can not be negative");
                }
                this.years = value;
            }
        }
        public override string ToString()
        {
            return $"{this.interestCalcDelegate(this.Money, this.Interest, this.Years):F4}";
        }
    }
}
