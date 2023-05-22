using Interfaces.Core;
using Interfaces.Persistence;

namespace Domain.Core.Coupons
{
    public class CouponValidator : ICouponValidator
    {
        private readonly IGenericRepository<ICoupon> _couponsRepository;

        public CouponValidator(IGenericRepository<ICoupon> couponsRepository)
        {
            _couponsRepository = couponsRepository;
        }

        public virtual bool Validate(ICoupon coupon)
        {
            var isValid = _couponsRepository
                .Query(e => e.Code.ToLowerInvariant()
                .Equals(coupon.Code.ToLowerInvariant()))
                .FirstOrDefault();

            return isValid == null ? false : true;
        }
    }
}
