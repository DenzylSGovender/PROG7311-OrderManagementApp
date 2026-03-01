using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class NotificationServices
    {
        public string Notify(string type, string message)
        {
            INotification notification;

            if (type == "Email")
                notification = new EmailNotification();
            else if (type == "SMS")
                notification = new SMSNotification();
            else
                return "Invalid notification type";

            return notification.Send(message);
        }
    }
}
