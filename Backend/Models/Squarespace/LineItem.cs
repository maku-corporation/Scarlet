using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class LineItem
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("variantId")]
        public string variantId { get; set; }

        [JsonPropertyName("sku")]
        public string sku { get; set; }

        [JsonPropertyName("weight")]
        public double weight { get; set; }

        [JsonPropertyName("width")]
        public double width { get; set; }

        [JsonPropertyName("length")]
        public double length { get; set; }

        [JsonPropertyName("height")]
        public double height { get; set; }

        [JsonPropertyName("productId")]
        public string productId { get; set; }

        [JsonPropertyName("productName")]
        public string productName { get; set; }

        [JsonPropertyName("quantity")]
        public int quantity { get; set; }

        [JsonPropertyName("unitPricePaid")]
        public UnitPricePaid unitPricePaid { get; set; }

        [JsonPropertyName("variantOptions")]
        public List<VariantOption> variantOptions { get; set; }

        [JsonPropertyName("customizations")]
        public List<Customization> customizations { get; set; }

        [JsonPropertyName("imageUrl")]
        public string imageUrl { get; set; }

        [JsonPropertyName("lineItemType")]
        public string lineItemType { get; set; }
    }
}
