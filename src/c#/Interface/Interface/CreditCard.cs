namespace Interface;
// Implementação da interface IPaymentMethod para pagamento via cartão de crédito
public class CreditCard : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via Credit Card to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via Credit Card\n");
    }
}