using Banking.Domain;

namespace Banking.UnitTests
{
    public class NotifyOnOverdraft
    {
        [Fact]
        public void TheBankAccountNotifiesIfThereIsAnOverdraft()
        {
            var mockedNotifier = new Mock<INotifyAccountRep>();
            var account = new BankAccount(new Mock<IBonusCalculator>().Object, mockedNotifier.Object);
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance + 1M;

            try
            {
                account.Withdraw(amountToWithdraw); // Force an overdraft.
            }
            catch (Exception)
            {
                // ignore it
            }

            // Verify the notifier was called
            mockedNotifier.Verify(m => m.AttemptedOverdraftNotification(account, openingBalance, amountToWithdraw), Times.Once());
        }

        [Fact]
        public void TheBankAccountDoesNotNotifyIfThereIsNoOverdraft()
        {
            var mockedNotifier = new Mock<INotifyAccountRep>();
            var account = new BankAccount(new Mock<IBonusCalculator>().Object, mockedNotifier.Object);
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance;

            account.Withdraw(amountToWithdraw);

            // Verify the notifier was not called
            mockedNotifier.Verify(m => m.AttemptedOverdraftNotification(account, openingBalance, amountToWithdraw), Times.Never());
        }
    }
}
