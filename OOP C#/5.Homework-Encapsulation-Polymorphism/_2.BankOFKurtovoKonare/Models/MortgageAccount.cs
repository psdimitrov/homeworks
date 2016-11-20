namespace _2.BankOFKurtovoKonare.Models
{
    using Interfaces;

    public class MortgageAccount : AccountBase
    {
        public MortgageAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= this.Customer.MortgageRateMinDuration)
            {
                return base.CalculateInterest(months / 2);
            }

            return base.CalculateInterest(months);
        }
    }
}
