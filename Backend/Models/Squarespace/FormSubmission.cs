using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class FormSubmission
    {
        [JsonPropertyName("label")]
        public string label { get; set; }

        [JsonPropertyName("value")]
        public string value { get; set; }
    }
}
