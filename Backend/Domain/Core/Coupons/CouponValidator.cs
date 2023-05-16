using Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Coupons
{
    public class CouponValidator : ICouponValidator
    {
        private readonly IValidator _validator;

        public CouponValidator(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(ICoupon coupon)
        {
            return _validator.Validate(coupon);
        }
    }
}
