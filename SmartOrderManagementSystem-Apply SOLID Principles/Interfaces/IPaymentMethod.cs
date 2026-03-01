namespace SmartOrderManagementSystem.Interfaces
{
    public interface IPaymentMethod
    {
        string ProcessPayment(double amount);
    }
}
