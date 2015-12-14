namespace _2.BankOFKurtovoKonare.Models
{
    using Interfaces;

    public class LoanAccount : AccountBase
    {
        public LoanAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= this.Customer.DepositRateMinDuration)
            {
                return this.Ballance;
            }

            return base.CalculateInterest(months - this.Customer.DepositRateMinDuration);
        }
    }
}
