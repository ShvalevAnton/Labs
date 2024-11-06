using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class BankTransaction
{
    private readonly decimal amount;
    private readonly DateTime when;   

    public BankTransaction(decimal tranAmount)
    {
        this.amount = tranAmount;
        when = DateTime.Now;
    }

    public decimal Amount()
    {
        return amount;
    }
    public DateTime When()
    {
        return when;
    }


}

