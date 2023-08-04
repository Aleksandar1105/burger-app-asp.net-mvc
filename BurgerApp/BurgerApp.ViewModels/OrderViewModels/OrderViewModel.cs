using BurgerApp.Domain.Models;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsDelivered { get; set; }
        public int LocationId { get; set; }
    }
}
