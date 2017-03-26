namespace StrategyDesignPatternDemo
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        public double CalculateFee()
        {
            return 3d;
        }
    }
}
