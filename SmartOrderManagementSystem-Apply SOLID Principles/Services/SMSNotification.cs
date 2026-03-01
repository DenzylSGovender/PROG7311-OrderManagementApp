using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class SMSNotification : INotification
    {
        public string Send(string message)
        {
            return "SMS sent: " + message;
        }
    }
}
