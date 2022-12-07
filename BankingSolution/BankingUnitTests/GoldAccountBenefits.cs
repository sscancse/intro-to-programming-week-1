using Banking.Domain;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Fact]
        public void GetBonusOnDeposit()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var deposit = 100M;
            var expectedBonus = 10M;

            account.Deposit(deposit);

            Assert.Equal(openingBalance + deposit + expectedBonus, account.GetBalance());
        }
    }
}
