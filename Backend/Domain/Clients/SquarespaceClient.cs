using Interfaces.Squarespace.Clients;
using Models.Squarespace;
using RestSharp;
using System.Configuration;

namespace Domain.Clients
{
    public class SquarespaceClient : ISquarespaceClient, IDisposable
    {
        private readonly IRestClient _client;

        private const string RESOURCE_COMMERCE_ORDERS = "commerce/orders";
        private const string RESOURCE_COMMERCE_TRANSACTIONS = "commerce/transactions";

        public SquarespaceClient(IRestClient client)
        {
            var protocol = ConfigurationManager.AppSettings["protocol"];
            var endpoint = ConfigurationManager.AppSettings["endpoint"];
            var version = ConfigurationManager.AppSettings["version"];
            var key = ConfigurationManager.AppSettings["key"];

            // TODO: Create seperate class for collection app settings

            var options = new RestClientOptions(baseUrl: $"{protocol}{endpoint}{version}/");

            _client = new RestClient(options)
                .AddDefaultHeader(KnownHeaders.ContentType, "application/json")
                .AddDefaultHeader(KnownHeaders.Authorization, $"Bearer {key}");
        }

        public async Task<OrderItems> GetAllOrders()
        {
            var request = new RestRequest(RESOURCE_COMMERCE_ORDERS, Method.Get);
            var response = await _client.GetAsync<OrderItems>(request);

            return response;
        }

        public async Task<Order> GetOrderById(string id)
        {
            var request = new RestRequest(RESOURCE_COMMERCE_ORDERS, Method.Get);
            var result = await _client.GetAsync<OrderItems>(request);

            var order = from orderItem in result?.Orders
                        where orderItem.id == id
                        select orderItem;

            return order.First();
        }

        public async Task<TransactionItems> GetTransactions()
        {

            var request = new RestRequest(RESOURCE_COMMERCE_TRANSACTIONS, Method.Get);
            var response = await _client.GetAsync<TransactionItems>(request);

            return response;
        }

        public async Task<Transaction> GetTransactionById(string id)
        {
            var request = new RestRequest(RESOURCE_COMMERCE_TRANSACTIONS, Method.Get);
            var result = await _client.GetAsync<TransactionItems>(request);

            var transaction = from transactionItem in result?.transactions
                              where transactionItem.id == id
                              select transactionItem;

            return transaction.First();
        }


        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
