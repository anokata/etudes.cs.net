using System;

public class BankAccount
{

    private decimal balance = 0;
    private bool opened = false;
    private readonly object locker = new Object();

    public void Open()
    {
        lock (locker)
        {
            opened = true;
        }
    }

    public void Close()
    {
        lock (locker)
        {
            opened = false;
        }
    }

    public decimal Balance
    {
        get  {
            lock (locker)
            {
                if (!opened) throw new InvalidOperationException("Account is closed.");
                return balance;
            }
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock (locker)
        {
            balance += change;
        }
    }
}
