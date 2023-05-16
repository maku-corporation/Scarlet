using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class UnitPricePaid
    {
        [JsonPropertyName("value")]
        public string Value;

        [JsonPropertyName("currency")]
        public string Currency;
    }
}
