using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class PaymentFactory
    {
        public static IPaymentMethod Create(string type)
        {
            if (type == "Card")
                return new CreditCardPayment();

            if (type == "PayPal")
                return new PayPalPayment();

            throw new Exception("Invalid Payment");
        }
    }
}
