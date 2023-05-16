﻿using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class GrandTotal
    {
        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("value")]
        public string value { get; set; }
    }
}
