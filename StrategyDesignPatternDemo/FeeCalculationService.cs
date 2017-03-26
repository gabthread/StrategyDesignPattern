namespace StrategyDesignPatternDemo
{
    public class FeeCalculationService
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public FeeCalculationService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public double CalculateFeeBasedOnPaymentOption()
        {
            return _paymentStrategy.CalculateFee();
        }
    }
}
