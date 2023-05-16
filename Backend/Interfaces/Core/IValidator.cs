using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Core
{
    public interface IValidator
    {
        bool Validate(ICoupon coupon);
    }
}
