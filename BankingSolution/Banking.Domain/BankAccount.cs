namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance;
        public void Deposit(decimal deposit)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal withdrawal)
        {
            _balance -= withdrawal;
        }
    }
}