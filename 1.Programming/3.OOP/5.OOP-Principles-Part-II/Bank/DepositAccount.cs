using System;

class DepositAccount : Account, IWithdraw
{
    public DepositAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
    {
    }

    public override decimal CalculateInterestAmount(int period)
    {
        if (period < 0)
        {
            throw new ArgumentOutOfRangeException("period must be positive value");
        }

        if (this.Balance > 0 && this.Balance < 1000)
        {
            return 0;
        }
        else
        {
            return base.CalculateInterestAmount(period);
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("amount must be positive value");
        }
        if (this.Balance < amount)
        {
            throw new InvalidOperationException("withdraw amount must be less than the balance of the account");
        }

        this.Balance -= amount;
    }
}

