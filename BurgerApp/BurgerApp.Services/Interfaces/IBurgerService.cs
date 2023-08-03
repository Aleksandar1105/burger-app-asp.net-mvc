namespace BurgerApp.Services.Interfaces
{
    using BurgerApp.ViewModels.BurgerViewModels;
    public interface IBurgerService
    {
        Task<List<BurgerListViewModel>> GetBurgersForCards();

        Task<BurgerDetailsViewModel> GetBurgerDetails(int id);

        Task<int> DeleteBurgerById(int id);

        Task CreateBurger(BurgerViewModel burgerViewModel);

        Task<BurgerViewModel> GetBurgerForEditing(int id);

        Task EditBurger(BurgerViewModel burgerViewModel);
    }
}
