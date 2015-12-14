namespace _2.BankOFKurtovoKonare
{
    using System;
    using Interfaces;
    using Models;

    public static class Program
    {
        public static void Main()
        {
            ICustomer[] clients =
            {
                new IndividualCustomer("Dimitar Dimitrov"),
                new IndividualCustomer("Petar Ivanov"),
                new CompanyCustomer("Glavbulgarstroy OOD"),
                new CompanyCustomer("Monbat AD"),
            };

            var depositAccount = new DepositAccount(clients[0], 18000m, 0.004);
            var loanAccount = new LoanAccount(clients[1], 500m, 0.015);
            var mortgageAccount = new MortgageAccount(clients[0], 5000m, 0.009);
            var depositAccount2 = new DepositAccount(clients[2], 100000m, 0.010);
            var depositAccount3 = new DepositAccount(clients[3], 1200, 0.08);


            depositAccount.Withdraw(1000m);
            depositAccount2.Withdraw(500m);
            mortgageAccount.Deposit(15m);
            loanAccount.Deposit(100m);

            try
            {
                depositAccount.Withdraw(100000m);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            Console.WriteLine(depositAccount2);
            Console.WriteLine(mortgageAccount);

            Console.WriteLine(loanAccount + string.Format(" Interest : {0:C}", loanAccount.CalculateInterest(12)));
        }
    }
}
