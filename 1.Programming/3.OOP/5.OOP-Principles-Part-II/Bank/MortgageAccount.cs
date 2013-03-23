using System;

class MortgageAccount : Account
{
    public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
    {
    }

    public override decimal CalculateInterestAmount(int period)
    {
        if (period < 0)
        {
            throw new ArgumentOutOfRangeException("period must be positive value");
        }

        if (this.Customer is Individual)
        {
            return CalculateInterestAmount(period, 6, 0M);
        }
        else if (this.Customer is Company)
        {
            return CalculateInterestAmount(period, 12, 0.5M);
        }
        else
        {
            return base.CalculateInterestAmount(period);
        }
    }

    private decimal CalculateInterestAmount(int period, int initialPeriod, decimal rate)
    {
        decimal interest = initialPeriod * this.InterestRate * rate;

        if (period - initialPeriod > 0)
        {
            interest += (period - initialPeriod) * this.InterestRate;
        }

        return interest;
    }


}

