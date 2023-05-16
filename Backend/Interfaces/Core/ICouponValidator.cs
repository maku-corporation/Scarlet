using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Core
{
    public interface ICouponValidator
    {
        bool Validate(ICoupon coupon);
    }
}
