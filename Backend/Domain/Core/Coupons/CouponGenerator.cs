using Interfaces.Core;

namespace Domain.Core.Coupons
{
    public class CouponGenerator : ICouponGenerator
    {
        private readonly IGenerator _generator;

        public CouponGenerator(IGenerator generator)
        {
            _generator = generator;
        }
        
        public ICoupon Generate()
        {
            return _generator.GenerateCoupon();
        }
    }
}
