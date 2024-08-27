namespace Interface;
// Interface que define o contrato para métodos de pagamento
public interface IPaymentMethod
{
    void ProcessPayment(decimal value);
    void GetPaymentInfo();
    
    
}