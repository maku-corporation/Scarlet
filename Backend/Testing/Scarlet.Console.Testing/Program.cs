// See https://aka.ms/new-console-template for more information

using Domain.Clients;
using Domain.Core.Coupons;
using Interfaces.Squarespace.Clients;
using Interfaces.Squarespace.Endpoints;
using Models.Squarespace;
using RestSharp;

#region Squarespace client

//ISquarespaceClient client = new SquarespaceClient(new RestClient());
//var orderItems = await client.GetAllOrders();
//var order = await client.GetOrderById("63ad9daecf87cd4ad0966ac5");

//var transactions = await client.GetTransactions();
//var transaction = await client.GetTransactionById("2543e69d-c795-4638-a48e-1809c011b5a2");

//Console.WriteLine("###### ORDERS ######");

//foreach (var item in orderItems.Orders)
//{
//    Console.WriteLine("Order ID: " + item.id);
//    Console.WriteLine("Channel name: " + item.channelName + "\n");
//}

#endregion

/**
    Prefix - TX or similar(2 characters)
    Timestamp - YYMMDDHHMMSS(12 characters)
    Random number - 1001 and 9999 (4 characters)

    Example: TX1312161301239999(TX | 131216130123 | 9999)

    0,7529956188518554
    0,7064501561690122
    0,5752364536747336
    0,11783273401670158
    0,0758568050805479
 */
List<double> doubles = new List<double>();
RandomGenerator random = new RandomGenerator();
for (int i = 0; i < 100; i++)
{
    //Console.WriteLine(random.NextDouble()
    //    .ToString()
    //    .Split(',')
    //    .Last());

    var prefix = "TX";
    var timeStamp = DateTime.Now.ToString("FFFFFFF").Substring(0, 4);
    var randomNumber = random.NextDouble().ToString().Split(',').Last().Substring(0, 4);

    Console.Write(prefix + timeStamp + randomNumber + "\n");
}
Console.ReadKey();
