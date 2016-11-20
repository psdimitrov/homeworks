namespace _2.BankOFKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Ballance { get; }

        double InterestRate { get; }

        decimal CalculateInterest(int months);
    }
}
