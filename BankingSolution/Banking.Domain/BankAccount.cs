namespace Banking.Domain
{
    public enum BankAccountType { Standard, Gold };

    public class BankAccount
    {
        public BankAccountType AccountType = BankAccountType.Standard;
        private decimal _balance = 5000;

        public void Deposit(decimal deposit)
        {
            decimal bonus = AccountType == BankAccountType.Gold ? deposit * .1M : 0;

            _balance += deposit + bonus;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal withdrawal)
        {
            if (withdrawal > _balance)
            {
                throw new OverdraftException();
            } else
            {
                _balance -= withdrawal;
            }
        }
    }
}