using SneakerShop.Data.Models;

namespace SneakerShop.Data.Interfaces
{
    public interface IOrders
    {
        void CreateOrder(Order order);
    }
}