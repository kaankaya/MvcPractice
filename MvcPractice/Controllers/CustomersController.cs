using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;

namespace MvcPractice.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            //Model Örneği Oluştur
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Sertan",
                LastName = "Bozkuş",
                Email = "sertan.bozkus@example.com"
            };
            var orders = new List<Order>
                {
                     new Order { Id = 1, ProductName = "Laptop", Price = 999.99m, Quantity = 1 },
                     new Order { Id = 2, ProductName = "Mouse", Price = 19.99m, Quantity = 2 }
                };
            //ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                Orders = orders,
                WelcomeMessage = "Welcome to our customer portal!"
            };

            return View(viewModel);
        }
    }
}
