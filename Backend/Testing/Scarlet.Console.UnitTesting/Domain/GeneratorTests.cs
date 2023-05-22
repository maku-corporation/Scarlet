using Domain.Entities;
using Interfaces.Core;
using Moq;

namespace Scarlet.Console.UnitTesting.Domain
{
    [TestClass]
    public class GeneratorTests
    {
        private Mock<IGenerator>? _generatorStub;

        [TestInitialize] 
        public void Init() 
        {
            _generatorStub = new Mock<IGenerator>();
        }

        [TestMethod]
        public void GenerateCouponTest()
        {
            _generatorStub?.Setup(e => e.GenerateCoupon())
                           .Returns(new Coupon() { Code = "0000" });

            var coupon = _generatorStub?.Object.GenerateCoupon();
            Assert.IsNotNull(coupon);
            Assert.AreEqual("0000", coupon.Code);

        }
    }
}
