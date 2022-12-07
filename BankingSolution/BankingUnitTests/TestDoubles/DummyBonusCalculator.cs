using Banking.Domain;

namespace Banking.UnitTests.TestDoubles
{
    public class DummyBonusCalculator : IBonusCalculator
    {
        public decimal GetBonus(decimal balance, decimal deposit)
        {
            return 0;
        }
    }
}
