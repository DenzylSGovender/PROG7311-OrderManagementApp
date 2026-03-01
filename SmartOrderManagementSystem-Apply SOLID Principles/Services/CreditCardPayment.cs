using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment(double amount)
        {
            return $"Credit Card payment processed: {amount}";
        }
    }
}
