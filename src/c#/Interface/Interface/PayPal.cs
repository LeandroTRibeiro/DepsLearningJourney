namespace Interface;
// Implementação da interface IPaymentMethod para pagamento via PayPal
public class PayPal : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via PayPal to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via PayPal\n");
    }
}