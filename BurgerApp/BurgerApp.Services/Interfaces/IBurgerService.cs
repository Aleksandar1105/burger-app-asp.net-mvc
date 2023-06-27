namespace BurgerApp.Services.Interfaces
{
using BurgerApp.ViewModels.BurgerViewModels;
    public interface IBurgerService
    {
        Task<List<BurgerListViewModel>> GetBurgersForCards();
    }
}
