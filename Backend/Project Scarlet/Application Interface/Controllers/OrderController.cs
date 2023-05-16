using Interfaces.Squarespace.Clients;
using Microsoft.AspNetCore.Mvc;
using Models.Squarespace;

namespace Application_Interface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly ISquarespaceClient _squarespaceClient;

        public OrderController(ILogger<OrderController> logger, ISquarespaceClient squarespaceClient)
        {
            _logger = logger;
            _squarespaceClient = squarespaceClient;
        }

        [HttpGet(Name = "GetOrders")]
        public async Task<OrderItems> GetOrdersAsync()
        {
            if (_squarespaceClient is null)
            {
                _logger.LogWarning(new EventId(1), message: "");
                return new OrderItems();
            }
            else
            {
                return await _squarespaceClient.GetAllOrders();
            }
        }
    }
}