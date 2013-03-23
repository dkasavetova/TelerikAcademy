using System;

class LoanAccount : Account
{
    public LoanAccount(Customer customer, decimal balance, decimal interestRate)
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
            return CalculateInterestAmount(period, 3);
        }
        else if (this.Customer is Company)
        {
            return CalculateInterestAmount(period, 2);
        }
        else
        {
            return base.CalculateInterestAmount(period);
        }
    }

    private decimal CalculateInterestAmount(int period, int stallPeriod)
    {
        if (period <= stallPeriod)
        {
            return 0;
        }
        else
        {
            decimal interest = (period - stallPeriod) * this.InterestRate;
            return interest;
        }
    }
}

