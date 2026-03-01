using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem
{
    public class SMSNotification : INotification
    {
        public string Send(string message)
        {
            return "SMS sent: " + message;
        }
    }
}
