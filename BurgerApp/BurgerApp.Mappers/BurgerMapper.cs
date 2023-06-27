namespace BurgerApp.Mappers
{
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.BurgerViewModels;
    public static class BurgerMapper
    {
        public static BurgerListViewModel ToBurgerListViewModel(this Burger burger)
        {
            return new BurgerListViewModel()
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
            };
        }
    }
}
