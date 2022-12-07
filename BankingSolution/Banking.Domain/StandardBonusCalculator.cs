namespace Banking.Domain
{
    public class StandardBonusCalculator : IBonusCalculator
    {
        public decimal GetBonus(decimal balance, decimal deposit)
        {
            return balance >= 5000M ? deposit * .1M : 0;
        }
    }
}