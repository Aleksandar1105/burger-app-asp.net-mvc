using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using BurgerApp.Mappers;
using BurgerApp.DataAccess.Repositories.Implementations;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task Delete(int id)
        {
            var existingOrder = await _orderRepository.GetById(id);

            if (existingOrder == null)
            {
                throw new Exception($"Order with id {id} does not exist");
            }

            await _orderRepository.DeleteById(existingOrder.Id);
        }

        public async Task<OrderViewModel> Details(int id)
        {
            var order = await _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order.ToViewModel();
        }

        public async Task<List<OrderViewModel>> GetAll()
        {
            List<Order> ordersDb = await _orderRepository.GetAll();

            return ordersDb.Select(x => x.ToViewModel()).ToList();
        }

        public async Task<int> Save(OrderViewModel model)
        {
            var order = new Order()
            {
                FullName = model.FullName,
                Address = model.Address,
                IsDelivered = model.IsDelivered,
                LocationId = model.LocationId
            };

            if (model.Id != 0)
            {
                order.Id = model.Id;
                await _orderRepository.Update(order);
            }
            else
            {
                await _orderRepository.Insert(order);
            }


            return order.Id;
        }
    }
}
