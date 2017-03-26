namespace StrategyDesignPatternDemo
{
    public class PaypalStrategy : IPaymentStrategy
    {
        public double CalculateFee()
        {
            return 2.00d;
        }
    }
}
