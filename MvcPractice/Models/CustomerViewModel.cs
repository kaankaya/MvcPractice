namespace MvcPractice.Models
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
        public string WelcomeMessage { get; set; } //Ekstra bir veri
    }
}
