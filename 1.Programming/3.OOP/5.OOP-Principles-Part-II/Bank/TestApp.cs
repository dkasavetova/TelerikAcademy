using System;

class TestApp
{
    static void Main()
    {
        Bank bank = new Bank();

        DepositAccount depAccC = new DepositAccount(new Company(), 300M, 0.4M);
        DepositAccount depAccI = new DepositAccount(new Individual(), 1000M, 0.4M);

        LoanAccount loanAccC = new LoanAccount(new Company(), 1000M, 0.4M);
        LoanAccount loanAccI = new LoanAccount(new Individual(), 1000M, 0.4M);

        MortgageAccount mortAccC = new MortgageAccount(new Company(), 1000M, 0.4M);
        MortgageAccount mortAccI = new MortgageAccount(new Individual(), 1000M, 0.4M);

        bank.AddAccount(depAccC);
        bank.AddAccount(depAccI);
        bank.AddAccount(loanAccC);
        bank.AddAccount(loanAccI);
        bank.AddAccount(mortAccC);
        bank.AddAccount(mortAccI);

        foreach (var acc in bank.Accounts)
        {
            Console.WriteLine(acc.CalculateInterestAmount(12));
        }
    }
}

