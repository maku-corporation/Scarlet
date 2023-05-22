using Interfaces.Core;
using Moq;

namespace Scarlet.Console.UnitTesting.Domain
{
    [TestClass]
    public class PrefixTests
    {
        private Mock<IPrefix>? _prefixStub;

        [TestInitialize] 
        public void Init() 
        {
            _prefixStub = new Mock<IPrefix>();
        }

        [TestMethod]
        public void GenerateCouponTest()
        {
            _prefixStub?.Setup(e => e.NextPrefix())
                        .Returns("SHPX");

            var prefix = _prefixStub?.Object.NextPrefix();
            Assert.IsNotNull(prefix);
            Assert.AreEqual("SHPX", prefix);

        }
    }
}
