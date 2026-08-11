using System;

namespace PaymentSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Credit Card
            CreditCard creditCard = new CreditCard(500, 300);

            bool creditResult = PaymentProcessor.ProcessPayment(creditCard, 700);

            Console.WriteLine("Credit Card:");
            Console.WriteLine($"Success: {creditResult}");
            Console.WriteLine($"Remaining Balance: {creditCard.Balance}");

            Console.WriteLine();

            // Debit Card
            DebitCard debitCard = new DebitCard(500);

            bool debitResult = PaymentProcessor.ProcessPayment(debitCard, 700);

            Console.WriteLine("Debit Card:");
            Console.WriteLine($"Success: {debitResult}");
            Console.WriteLine($"Remaining Balance: {debitCard.Balance}");
        }
    }
}