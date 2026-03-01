namespace SmartOrderManagementSystem.Models
{
    public class Order
    {
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public string PaymentType { get; set; }
        public string NotificationType { get; set; }
    }
}
