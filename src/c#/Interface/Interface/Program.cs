namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de diferentes métodos de pagamento, todos implementando a interface IPaymentMethod
            List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>()
            {
                new CreditCard(),
                new PayPal(),
                new BankTransfer()
            };

            // Itera sobre a lista e processa o pagamento usando cada método
            foreach (IPaymentMethod paymentMethod in paymentMethods)
            {
                paymentMethod.ProcessPayment(100);
                paymentMethod.GetPaymentInfo();
            }


        }
    }
}