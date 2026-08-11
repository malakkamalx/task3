namespace PaymentSystem
{
    // Process Payment
    public class PaymentProcessor
    {
        public static bool ProcessPayment(PaymentMethod paymentMethod, decimal amount)
        {
            return paymentMethod.Charge(amount);
        }
    }
}