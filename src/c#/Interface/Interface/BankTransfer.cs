namespace Interface;
// Implementação da interface IPaymentMethod para pagamento via transferência bancária
public class BankTransfer : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via Bank Transfer to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via Bank Transfer\n");
    }
}