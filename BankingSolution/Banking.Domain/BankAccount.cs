namespace Banking.Domain
{
    public class BankAccount
    {
        private readonly IBonusCalculator _calculator;
        private decimal _balance = 5000;

        public BankAccount(IBonusCalculator calculator)
        {
            _calculator = calculator;
        }

        public void Deposit(decimal deposit)
        {
            var bonus = _calculator.GetBonus(_balance, deposit);
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
            }
            else
            {
                _balance -= withdrawal;
            }
        }
    }
}