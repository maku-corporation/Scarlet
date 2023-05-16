using Domain.Entities;
using Interfaces.Core;

namespace Domain.Core.Coupons
{
    public class Generator : IGenerator
    {
        private readonly IRandomGenerator _randomGenerator;
        private readonly IPrefix _prefix;

        public Generator(IRandomGenerator randomGenerator, IPrefix prefix)
        {
            _randomGenerator = randomGenerator;
            _prefix = prefix;
        }

        public ICoupon GenerateCoupon()
        {
            string prefix = _prefix.NextPrefix();
            string timeStamp = DateTime.Now.ToString("FFFFFFF").Substring(0, 4);
            string randomNumber = _randomGenerator.NextDouble().ToString().Split(',').Last().Substring(0, 4);


            ICoupon coupon = new Coupon();
            coupon.Code = (prefix + timeStamp + randomNumber).ToString();

            return coupon;
        }
    }
}
