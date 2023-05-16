using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class SalesLineItem
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("discountAmount")]
        public DiscountAmount discountAmount { get; set; }

        [JsonPropertyName("totalSales")]
        public TotalSales totalSales { get; set; }

        [JsonPropertyName("totalNetSales")]
        public TotalNetSales totalNetSales { get; set; }

        [JsonPropertyName("total")]
        public Total total { get; set; }

        [JsonPropertyName("taxes")]
        public List<Taxis> taxes { get; set; }
    }
}
