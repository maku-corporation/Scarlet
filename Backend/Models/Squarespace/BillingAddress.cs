using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class BillingAddress
    {
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("address1")]
        public string address1 { get; set; }

        [JsonPropertyName("address2")]
        public string address2 { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("state")]
        public string state { get; set; }

        [JsonPropertyName("countryCode")]
        public string countryCode { get; set; }

        [JsonPropertyName("postalCode")]
        public string postalCode { get; set; }

        [JsonPropertyName("phone")]
        public string phone { get; set; }
    }
}
