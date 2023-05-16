using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class VariantOption
    {
        [JsonPropertyName("optionName")]
        public string OptionName;

        [JsonPropertyName("value")]
        public string Value;
    }
}
