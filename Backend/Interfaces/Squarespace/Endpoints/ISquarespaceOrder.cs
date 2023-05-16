using Models.Squarespace;

namespace Interfaces.Squarespace.Endpoints
{
    public interface ISquarespaceOrder : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<OrderItems> GetAllOrders();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Order> GetOrderById(string id);
    }
}
