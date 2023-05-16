using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Taxis
    {
        [JsonPropertyName("amount")]
        public Amount Amount;

        [JsonPropertyName("rate")]
        public string Rate;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("jurisdiction")]
        public string Jurisdiction;
    }
}
