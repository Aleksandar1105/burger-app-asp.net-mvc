using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        public Task<List<OrderViewModel>> GetOrderForList()
        {
            throw new NotImplementedException();
        }
    }
}
