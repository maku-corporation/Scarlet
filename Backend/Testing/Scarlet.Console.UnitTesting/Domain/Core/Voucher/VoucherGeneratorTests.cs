using Domain.Core.Coupons;
using Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scarlet.Console.UnitTesting.Domain.Core.Voucher
{
    [TestClass]
    public class VoucherGeneratorTests
    {
        [TestMethod]
        public void GenerateVoucher()
        {
            IRandomGenerator randomGenerator = new RandomGenerator();
            IPrefix prefix = new Prefix();
            IGenerator generator = new Generator(randomGenerator, prefix);

            ICouponGenerator couponGenerator = new CouponGenerator(generator);
            ICoupon coupon = couponGenerator.Generate();
            Trace.WriteLine("Generated coupon ID: " + coupon.Code);
            Assert.IsNotNull(coupon);
        }

        [TestMethod]
        public void ValidateVoucher()
        {
            ICoupon voucher = null;
            IValidator validator = null;

            bool isValid = validator.Validate(voucher);

            Assert.IsNotNull(isValid);
            Assert.IsTrue(isValid);
        }
    }
}
