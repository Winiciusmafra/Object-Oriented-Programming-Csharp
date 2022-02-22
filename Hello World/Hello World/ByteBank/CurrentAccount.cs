using ByteBank;

namespace ByteBank
{

    public class CurrentAcconut
    {
        private int _agency;
        private int _currentAccount;
        private double _balance;
        public int agency { get; set; }
        public int currentAccount { get; set; }
        public Holder Holder { get; set; }
        public double Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this._balance = value;
                }
            }
        }

        public CurrentAcconut(int agency, int currentAccount )
        {
            this.agency = agency;
            this.currentAccount = currentAccount; 
        }

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



    }
}
