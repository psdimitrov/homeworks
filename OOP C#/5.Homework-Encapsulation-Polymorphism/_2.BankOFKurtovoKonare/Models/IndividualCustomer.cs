namespace _2.BankOFKurtovoKonare.Models
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
            this.DepositRateMinDuration = 3;
            this.MortgageRateMinDuration = 6;
        }
    }
}
