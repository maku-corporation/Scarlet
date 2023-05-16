using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class OrderItems
    {
        [JsonPropertyName("result")]
        public List<Order> Orders { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}
