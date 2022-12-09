using Banking.Domain;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Fact]
        public void GetBonusOnDeposit()
        {
            var stubbedBonusCalculator = new Mock<IBonusCalculator>();
            var account = new BankAccount(stubbedBonusCalculator.Object, new Mock<INotifyAccountRep>().Object);
            var openingBalance = account.GetBalance();
            var deposit = 92.42M;
            var expectedBonus = 42M;
            stubbedBonusCalculator.Setup(x => x.GetBonus(openingBalance, deposit)).Returns(expectedBonus);

            account.Deposit(deposit);

            Assert.Equal(openingBalance + deposit + expectedBonus, account.GetBalance());
        }
    }
}
