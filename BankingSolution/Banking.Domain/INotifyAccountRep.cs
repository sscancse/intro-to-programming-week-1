namespace Banking.Domain
{
    public interface INotifyAccountRep
    {
        void AttemptedOverdraftNotification(BankAccount account, decimal balance, decimal withdrawal);
    }
}