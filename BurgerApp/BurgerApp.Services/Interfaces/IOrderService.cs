using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderViewModel>> GetOrderForList();
    }
}
