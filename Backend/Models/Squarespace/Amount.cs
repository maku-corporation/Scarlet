﻿using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Amount
    {
        [JsonPropertyName("value")]
        public string value { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }
    }
}
