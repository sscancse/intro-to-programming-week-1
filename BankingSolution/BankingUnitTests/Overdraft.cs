using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests
{
    public class Overdraft
    {
        [Fact] // Safety Net - an "Invariant"
        public void CanTakeAllTheMoney()
        {
            var account = new BankAccount(new DummyBonusCalculator());

            account.Withdraw(account.GetBalance());

            Assert.Equal(0, account.GetBalance());
        }

        [Fact]
        public void OverdraftDoesNotDecreaseBalance()
        {
            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.GetBalance();
            var amountToWithDraw = openingBalance + .01M;

            // Exceptional Behavior
            try
            {
                account.Withdraw(amountToWithDraw); //  "No-op"
            }
            catch (OverdraftException)
            {

                // Ignore it.
            }

            Assert.Equal(openingBalance, account.GetBalance());
        }

        [Fact]
        public void OverdraftThrowsOverdraftException()
        {
            var account = new BankAccount(new DummyBonusCalculator());

            Assert.Throws<OverdraftException>(() =>
            {
                account.Withdraw(account.GetBalance() + .5M);
            });
        }
    }
}
