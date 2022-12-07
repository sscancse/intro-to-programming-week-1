using Banking.Domain;

namespace Banking.UnitTests.BonusCalculation
{
    public class DepositBonus
    {
        [Fact]
        public void AccountAboveThreshold()
        {
            var bonusCalculator = new StandardBonusCalculator();

            decimal bonus = bonusCalculator.GetBonus(5000M, 100M);

            Assert.Equal(10M, bonus);
        }

        [Fact]
        public void AccountBelowThreshold()
        {
            var bonusCalculator = new StandardBonusCalculator();

            decimal bonus = bonusCalculator.GetBonus(4999.99M, 100M);

            Assert.Equal(0M, bonus);
        }
    }
}
