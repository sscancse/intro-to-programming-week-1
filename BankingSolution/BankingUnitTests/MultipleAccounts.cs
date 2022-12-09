using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests
{
    public class MultipleAccounts
    {
        [Fact(Skip = "Classroom demonstration")]
        public void InstancesOfOurAccountAreIsolated()
        {
            /*
            var bobsAccount = new BankAccount(new DummyBonusCalculator());
            var suesAccount = new BankAccount(new DummyBonusCalculator());

            bobsAccount.Deposit(1000M);
            suesAccount.Withdraw(suesAccount.GetBalance());

            Assert.Equal(6000, bobsAccount.GetBalance());
            Assert.Equal(0, suesAccount.GetBalance());
            */
        }
    }
}
