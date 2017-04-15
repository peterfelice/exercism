using System;

public class BankAccount
{
    bool isOpen = false;
    float balance = 0;
    Object refLock = new Object();
    public void Open()
    {
        lock (refLock)
        {
            isOpen = true;
        }
    }

    public void Close()
    {
        lock (refLock)
        {
            isOpen = false;
        }
    }

    public float Balance
    {

        get
        {
            if (isOpen)
            {
                return balance;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

    public void UpdateBalance(float change)
    {
        if (isOpen)
        {
            lock (refLock)
            {
                balance += change;
            }
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}
