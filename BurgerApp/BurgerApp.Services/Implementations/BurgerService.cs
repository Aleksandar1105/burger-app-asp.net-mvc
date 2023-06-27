namespace BurgerApp.Services.Implementations
{
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.Domain.Models;
    using BurgerApp.Mappers;
    using BurgerApp.Services.Interfaces;
    using BurgerApp.ViewModels.BurgerViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BurgerService : IBurgerService
    {
        private IRepository<Burger> _burgerRepository;
        public BurgerService(IRepository<Burger> _burgerRepository)
        {
            this._burgerRepository = _burgerRepository;
        }

        public async Task<List<BurgerListViewModel>> GetBurgersForCards()
        {
            List<Burger> burgersDb = await _burgerRepository.GetAll();

            return burgersDb.Select(x => x.ToBurgerListViewModel()).ToList();
        }
    }
}
