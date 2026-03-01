using Microsoft.AspNetCore.Mvc;
using SmartOrderManagementSystem.Models;
using SmartOrderManagementSystem.Services;
using System.Diagnostics;

namespace SmartOrderManagementSystem.Controllers
{
    public class OrderController : Controller
    {
        private OrderServices service =
           new OrderServices();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {

            var result = service.ProcessOrder(order);

            ViewBag.PaymentResult = result.PaymentMessage;
            ViewBag.NotificationResult = result.NotificationMessage;

            return View();
        }
    }
}
