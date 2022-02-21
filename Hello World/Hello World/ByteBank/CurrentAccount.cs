using ByteBank;

namespace ByteBank
{

    public class CurrentAcconut
    {
        public Holder holder;
        public int agency;
        public int currentAccount;
        private double balance;

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
            if (value > 0)
            {
                this.balance += value;
            }
        }

        public bool Transfer(double value, CurrentAcconut current)
        {
            if (this.balance < value)
            {
                return false;
            }
            else
            {
                this.balance -= value;
                current.Deposit(value);
                return true;
            }
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double value)
        {
            if (balance < 0)
            {
                return;
            }
            else
            {
                this.balance = value;
            }
        }

    }
}
