using SmartOrderManagementSystem.Interfaces;

namespace SmartOrderManagementSystem
{
    public class EmailNotification : INotification
    {
        public string Send(string message)
        {
            return "Email sent: " + message;
        }
    }
}
