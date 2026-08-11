namespace PaymentSystem
{
    // Debit Card
    public class DebitCard : PaymentMethod
    {
        public DebitCard(decimal balance) : base(balance)
        {
        }

        // No override needed
        // It behaves exactly like PaymentMethod
    }
}