using SmartOrderManagementSystem.Interfaces;
using SmartOrderManagementSystem.Models;

namespace SmartOrderManagementSystem.Services
{
    public class OrderServices
    {
        private PaymentServices paymentService =
            new PaymentServices();

        private NotificationServices notificationService =
            new NotificationServices();

        public OrderResult ProcessOrder(Order order)
        {
            string paymentResult =
                paymentService.MakePayment(order.PaymentType, order.Amount);

            string notificationResult =
                notificationService.Notify(
                    order.NotificationType,
                    "Order Completed");

            return new OrderResult
            {
                PaymentMessage = paymentResult,
                NotificationMessage = notificationResult
            };
        }


    }
}
