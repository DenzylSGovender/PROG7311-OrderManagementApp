using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment(double amount)
        {
            return $"PayPal payment processed: {amount}";
        }
    }
}
