using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models.Squarespace
{
    public class Fulfillment
    {
        [JsonPropertyName("shipDate")]
        public DateTime shipDate { get; set; }

        [JsonPropertyName("carrierName")]
        public string carrierName { get; set; }

        [JsonPropertyName("service")]
        public object service { get; set; }

        [JsonPropertyName("trackingNumber")]
        public object trackingNumber { get; set; }

        [JsonPropertyName("trackingUrl")]
        public string trackingUrl { get; set; }
    }
}
