namespace Banking.Domain
{
    public interface IBonusCalculator
    {
        decimal GetBonus(decimal balance, decimal deposit);
    }
}