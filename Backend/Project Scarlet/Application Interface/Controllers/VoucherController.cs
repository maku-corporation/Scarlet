using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace Application_Interface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoucherController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public VoucherController(ILogger<OrderController> logger)
        {
            _logger = logger;            
        }

        [HttpGet("vouchers")]
        public async Task<IList<Coupon>> GetVouchers()
        {
            _logger.Log(LogLevel.Information, "Returning all vouchers...");

            return new List<Coupon>();
        }

        [HttpGet("voucher")]
        public async Task<Coupon> GetVoucher(string idenfitier)
        {
            _logger.Log(LogLevel.Information, "Returning a specific voucher with ID: {0}...", idenfitier);

            return new Coupon();
        }

        [HttpPost("voucher")]
        public async Task<Coupon> CreateVoucher(Customer customer)
        {
            _logger.Log(LogLevel.Information, "Creating a new voucher...");

            return new Coupon();
        }
    }
}
