namespace _2.BankOFKurtovoKonare.Models
{
    using Interfaces;
    using System;

    public abstract class AccountBase : IAccount, IDeposit
    {
        private decimal ballance;

        protected AccountBase(ICustomer customer, decimal ballance, double interesetrate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interesetrate;
        }

        public ICustomer Customer { get; }

        public decimal Ballance
        {
            get
            {
                return this.ballance;
            }

            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Initial balance must be positive");
                }
                this.ballance = value;
            }
        }

        public double InterestRate { get; }

        public void Deposit(decimal sum)
        {
            if(sum <= 0)
            {
                throw new ArgumentOutOfRangeException("Sum must be positive");
            }
            this.Ballance += sum;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Ballance * (1 + (decimal)(this.InterestRate * months));
        }
            

        public override string ToString()
        {
            return string.Format("{0} Ballance: {1:C}", this.Customer.Name, this.Ballance);
        }
            
    }
}
