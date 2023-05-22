using Interfaces.Core;
using Interfaces.Persistence;

namespace Domain.Core.Coupons
{
    public class CouponGenerator : ICouponGenerator
    {
        private readonly IGenerator _generator;

        public CouponGenerator(IGenerator generator)
        {
            _generator = generator;
        }
        
        public virtual ICoupon? Generate()
        {
            return _generator.GenerateCoupon();
        }
    }
}
