using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Customization
    {
        [JsonPropertyName("label")]
        public string Label;

        [JsonPropertyName("value")]
        public string Value;
    }
}
