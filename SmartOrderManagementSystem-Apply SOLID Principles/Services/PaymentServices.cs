using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class PaymentServices
    {
        public string MakePayment(string paymentType, double amount)
        {
            IPaymentMethod payment;

            if (paymentType == "Card")
                payment = new CreditCardPayment();

            else if (paymentType == "PayPal")
                payment = new PayPalPayment();

            else
                return "Invalid payment type";

            return payment.ProcessPayment(amount);
        }
    }
}
