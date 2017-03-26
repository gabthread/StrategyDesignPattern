namespace StrategyDesignPatternDemo
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public IPaymentStrategy PaymentOption { get; set; }
    }
}
