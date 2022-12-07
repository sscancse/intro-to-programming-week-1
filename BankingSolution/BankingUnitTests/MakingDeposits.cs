using Banking.Domain;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Fact]
        public void DepositIncreasesBalance()
        {
            // Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var deposit = 100M;
            // When
            account.Deposit(deposit);
            // Then
            Assert.Equal(deposit + openingBalance, account.GetBalance());
        }
    }
}
