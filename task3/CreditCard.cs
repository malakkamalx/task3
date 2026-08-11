namespace PaymentSystem
{
    // Credit Card
    public class CreditCard : PaymentMethod
    {
        public decimal CreditLimit { get; }

        public CreditCard(decimal balance, decimal creditLimit)
            : base(balance)
        {
            CreditLimit = creditLimit;
        }

        // Different behavior
        public override bool Charge(decimal amount)
        {
            if (Balance - amount >= -CreditLimit)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}