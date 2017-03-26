using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create order
            var order = new Order()
            {
                Id = 1,
                Address = "Dublin, Ireland",
                PaymentOption = new PaypalStrategy()
            };

            var feeCalculationService = new FeeCalculationService(order.PaymentOption);
            var fee = feeCalculationService.CalculateFeeBasedOnPaymentOption();

            Console.WriteLine("Calculated fee: " + fee);
            Console.ReadKey();


        }
    }
}
