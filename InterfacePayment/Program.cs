namespace InterfacePayment
{

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor; //field é uma variável que pertence a esta class, diferente de property que é uma forma controlada de aceder a um valor da class

        public PaymentService(IPaymentProcessor processor)//construtor
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount) //não escrevendo nada é private por defeito. método normal
        {
            _processor.ProcessPayment(amount);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor(); //criar um objeto da class derivada da interface (CreditCardProcessor)
            PaymentService paymentService = new PaymentService(creditCardProcessor); //criar um objeto da class PaymentService
            paymentService.ProcessOrderPayment(100.00m); //m to make sure its a decimal



        }
    }
}
