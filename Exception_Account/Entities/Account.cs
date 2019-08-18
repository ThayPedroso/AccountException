using System.Globalization;
using Exception_Account.Entities.Exceptions;

namespace Exception_Account.Entities
{
    class Account
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
