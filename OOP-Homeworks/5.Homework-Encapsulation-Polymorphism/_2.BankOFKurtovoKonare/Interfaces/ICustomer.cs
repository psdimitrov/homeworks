namespace _2.BankOFKurtovoKonare.Interfaces
{
    public interface ICustomer
    {
        string Name { get; }

        int DepositRateMinDuration { get; }

        int MortgageRateMinDuration { get; }
    }
}
