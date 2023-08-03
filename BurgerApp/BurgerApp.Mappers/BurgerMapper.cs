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
                ImgUrl = burger.ImageUrl,
                Price = burger.Price,
            };
        }

        public static BurgerDetailsViewModel ToBurgerDetailsViewModel(this Burger burger)
        {
            return new BurgerDetailsViewModel()
            {
                Name = burger.Name,
                Price = burger.Price,
                ImageUrl = burger.ImageUrl,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries
            };
        }

        public static Burger ToBurger(this BurgerViewModel burgerViewModel)
        {
            return new Burger()
            {
                Name = burgerViewModel.Name,
                Price = burgerViewModel.Price,
                ImageUrl = burgerViewModel.ImageUrl,
                IsVegetarian = burgerViewModel.IsVegetarian,
                IsVegan = burgerViewModel.IsVegan,
                HasFries = burgerViewModel.HasFries
            };
        }

        public static BurgerViewModel ToBurgerViewModel(this Burger burgerDb)
        {
            return new BurgerViewModel()
            {
                Id = burgerDb.Id,
                Name = burgerDb.Name,
                Price = burgerDb.Price,
                ImageUrl = burgerDb.ImageUrl,
                IsVegetarian = burgerDb.IsVegetarian,
                IsVegan = burgerDb.IsVegan,
                HasFries = burgerDb.HasFries
            };
        }
    }
}
