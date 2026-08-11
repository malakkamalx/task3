namespace PaymentSystem
{
    // Base Class

    public class PaymentMethod

    {
        public decimal Balance { get; protected set; }

        public PaymentMethod(decimal balance)
        {
            Balance = balance;
        }

        // Default behavior
        public virtual bool Charge(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}