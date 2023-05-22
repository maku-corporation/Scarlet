using Interfaces.Core;
using Moq;

namespace Scarlet.Console.UnitTesting.Domain
{
    [TestClass]
    public class ValidatorTests
    {
        private Mock<ICouponValidator>? _couponValidator;

        [TestInitialize] 
        public void Init() 
        {
            _couponValidator = new Mock<ICouponValidator>();
        }

        [TestMethod]
        public void Validate_returns_true()
        {
            var couponStub = new Mock<ICoupon>();

            _couponValidator?.Setup(e => e.Validate(couponStub.Object))
                             .Returns(true);

            var isValid = _couponValidator?.Object.Validate(couponStub.Object);
            Assert.IsTrue(isValid);

        }

        [TestMethod]
        public void Validate_returns_false()
        {
            var couponStub = new Mock<ICoupon>();

            _couponValidator?.Setup(e => e.Validate(couponStub.Object))
                             .Returns(false);

            var isValid = _couponValidator?.Object.Validate(couponStub.Object);
            Assert.IsFalse(isValid);

        }
    }
}
