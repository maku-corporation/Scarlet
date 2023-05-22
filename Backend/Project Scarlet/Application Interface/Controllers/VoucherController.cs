using Microsoft.AspNetCore.Mvc;
using Interfaces.Persistence;
using Domain.Entities.VOne;
using Domain.Filtering;

namespace Application_Interface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoucherController : ControllerBase
    {
        private readonly ILogger<VoucherController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public VoucherController(
            ILogger<VoucherController> logger,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet()]
        public async Task<IEnumerable<Coupon?>> GetVouchers()
        {
            _logger.Log(LogLevel.Information, "Returning all vouchers...");

            var coupons = await _unitOfWork.Repository().GetAllAsync<Coupon>();

            return coupons;
        }

        [HttpGet("searchById/{id}")]
        public async Task<Coupon?> GetVoucher(int id)
        {
            _logger.Log(LogLevel.Information, "Returning a specific voucher with ID: {0}...", id);

            var coupon = await _unitOfWork.Repository().GetByIdAsync<Coupon>(id);

            return coupon;
        }

        [HttpGet("searchByCode/{code}")]
        public async Task<Coupon?> GetVoucher(string code)
        {
            _logger.Log(LogLevel.Information, "Returning a specific voucher with ID: {0}...", code);

            var coupons = await _unitOfWork.Repository().GetAllAsync<Coupon>();

            return CouponFilter.FilterByCode(code, ref coupons);
        }
    }
}
