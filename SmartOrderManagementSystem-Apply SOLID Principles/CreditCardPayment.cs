using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem
{
    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment(double amount)
        {
            return $"Credit Card payment processed: {amount}";
        }
    }
}
