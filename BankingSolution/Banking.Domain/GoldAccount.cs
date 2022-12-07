namespace Banking.Domain
{
    public class GoldAccount : BankAccount
    {
        public override void Deposit(decimal deposit)
        {
            base.Deposit(deposit * 1.1M);
        }
    }
}