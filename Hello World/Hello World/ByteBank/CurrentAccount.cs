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

        //static belongs to class
        public static int _totalAccountsCreated { get; private set; }

        public CurrentAcconut(int agency, int currentAccount )
        {
            this._agency = agency;
            this._currentAccount = currentAccount;
            CurrentAcconut._totalAccountsCreated++;
        }


        public bool Withdraw(double value)
        {
            if (this._balance < value)
            {

                return false;

            }
            else
            {
                _balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            if (value > 0)
            {
                this._balance += value;
            }
        }

        public bool Transfer(double value, CurrentAcconut current)
        {
            if (this._balance < value)
            {
                return false;
            }
            else
            {
                this._balance -= value;
                current.Deposit(value);
                return true;
            }
        }



    }
}
