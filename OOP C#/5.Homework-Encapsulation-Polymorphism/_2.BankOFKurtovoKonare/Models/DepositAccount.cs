namespace _2.BankOFKurtovoKonare.Models
{
    using System;
    using Interfaces;

    public class DepositAccount : AccountBase, IWithdraw
    {
        public DepositAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public void Withdraw(decimal sum)
        {
            if (sum > this.Ballance)
            {
                throw new ArgumentException("Not enough money");
            }

            this.Ballance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Ballance < 1000)
            {
                return this.Ballance;
            }

            return base.CalculateInterest(months);
        }
    }
}
