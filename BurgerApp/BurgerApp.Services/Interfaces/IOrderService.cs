using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderViewModel>> GetAll();
        Task<int> Save(OrderViewModel model);
        Task<OrderViewModel> Details(int id);
        Task Delete(int id);
    }
}
