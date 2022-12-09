namespace Banking.Domain
{
    public class BankAccount
    {
        private readonly IBonusCalculator _calculator;
        private readonly INotifyAccountRep _notifier;
        private decimal _balance = 5000;

        public BankAccount(IBonusCalculator calculator, INotifyAccountRep notifier)
        {
            _calculator = calculator;
            _notifier = notifier;
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
                _notifier.AttemptedOverdraftNotification(this, _balance, withdrawal);
                throw new OverdraftException();
            }
            else
            {
                _balance -= withdrawal;
            }
        }
    }
}