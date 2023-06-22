namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; } = new List<Burger>();
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; } = new List<BurgerOrder>();
    }
}
