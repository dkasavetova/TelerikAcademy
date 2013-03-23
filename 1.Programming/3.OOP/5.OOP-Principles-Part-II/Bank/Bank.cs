using System.Collections.Generic;

class Bank
{
    private List<Account> accounts;

    public List<Account> Accounts
    {
        get
        {
            return new List<Account>(this.accounts);
        }
    }

    public Bank(List<Account> accounts)
    {
        this.accounts = accounts;
    }

    public Bank()
        :this(new List<Account>())
    {
    }

    public void AddAccount(Account acc)
    {
        this.accounts.Add(acc);
    }

}

