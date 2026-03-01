using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem.Services
{
    public class EmailNotification : INotification
    {
        public string Send(string message)
        {
            return "Email sent: " + message;
        }
    }
}
