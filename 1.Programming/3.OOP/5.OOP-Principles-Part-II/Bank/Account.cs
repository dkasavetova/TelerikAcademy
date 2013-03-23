using System;

abstract class Account : IDeposit
{
    public Customer Customer { get; set; }
    public decimal Balance { get; set; }
    public decimal InterestRate { get; set; }

    public Account(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public virtual decimal CalculateInterestAmount(int period)
    {
        decimal interest = period * this.InterestRate;
        return interest;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("amount must be positive value");
        }

        this.Balance += amount;
    }
}

