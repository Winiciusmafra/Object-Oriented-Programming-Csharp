public class CurrentAcconut
{
    public string holder;
    public int agency;
    public int currentAccount;
    public double balance;

    public bool withdraw(double value)
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

}