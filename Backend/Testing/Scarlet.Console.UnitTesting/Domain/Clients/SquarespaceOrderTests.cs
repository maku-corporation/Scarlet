using Domain.Clients;
using Interfaces.Squarespace.Endpoints;
using Models.Squarespace;
using RestSharp;

namespace Scarlet.Console.UnitTesting.Domain.Clients
{
    [TestClass]
    public class SquarespaceOrderTests
    {
        private readonly ISquarespaceOrder client = new SquarespaceClient(new RestClient());

        [TestCleanup]
        public void TestCleanup()
        {
            client?.Dispose();
        }

        [TestMethod]
        public async void GetAllOrdersTest()
        {
            OrderItems orderItems = await client.GetAllOrders();
            CollectionAssert.AllItemsAreNotNull(orderItems.Orders);
        }
    }
}