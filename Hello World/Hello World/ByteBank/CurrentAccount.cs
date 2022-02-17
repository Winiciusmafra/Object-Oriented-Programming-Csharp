public class CurrentAcconut
{
    public string holder;
    public int agency;
    public int currentAccount;
    public double balance;

    public bool Withdraw(double value)
    {
        if (this.balance < value)
        {
            
            return false;
            
        }
        else
        {
            balance -= value;
            return true;
        }
    }

    public void Deposit(double value)
    {
        if (value>0)
        {
            this.balance += value;
        }
    }
}