using Domain.Entities.VOne;

namespace Domain.Filtering
{
    public static class CouponFilter
    {
        public static Coupon FilterByCode(string code, ref IEnumerable<Coupon> coupons)
        {
            var filteredResult = from coupon in coupons
                                 where coupon.Code.ToLowerInvariant() == code.ToLowerInvariant()
                                 select coupon;

            if(filteredResult.Count() < 1) 
            {
                throw new UnknownFilterException("Too many items where found. Expected only one!");
            }

            return filteredResult.First();
        }
    }
}
