using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem
{
    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment(double amount)
        {
            return $"PayPal payment processed: {amount}";
        }
    }
}
