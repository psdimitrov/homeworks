namespace _2.BankOFKurtovoKonare.Models
{
    using Interfaces;
    public abstract class Customer : ICustomer
    {
        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int DepositRateMinDuration { get; protected set; }

        public int MortgageRateMinDuration { get; protected set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
