namespace BurgerApp.DataAccess.Repositories.Interfaces
{
    using BurgerApp.Domain.Models;
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task<int> DeleteById(int id);
    }
}
