using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests
{
    public class Overdraft
    {
        private readonly BankAccount _account;

        public Overdraft()
        {
            _account = new BankAccount(new Mock<IBonusCalculator>().Object, new Mock<INotifyAccountRep>().Object);
        }

        [Fact] // Safety Net - an "Invariant"
        public void CanTakeAllTheMoney()
        {
            _account.Withdraw(_account.GetBalance());

            Assert.Equal(0, _account.GetBalance());
        }

        [Fact]
        public void OverdraftDoesNotDecreaseBalance()
        {
            var openingBalance = _account.GetBalance();
            var amountToWithDraw = openingBalance + .01M;

            // Exceptional Behavior
            try
            {
                _account.Withdraw(amountToWithDraw); //  "No-op"
            }
            catch (OverdraftException)
            {

                // Ignore it.
            }

            Assert.Equal(openingBalance, _account.GetBalance());
        }

        [Fact]
        public void OverdraftThrowsOverdraftException()
        {
            Assert.Throws<OverdraftException>(() =>
            {
                _account.Withdraw(_account.GetBalance() + .5M);
            });
        }
    }
}
