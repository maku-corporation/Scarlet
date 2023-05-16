using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class TotalNetPayment
    {
        [JsonPropertyName("value")]
        public string value { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }
    }
}
