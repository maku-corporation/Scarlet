using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Payment
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("amount")]
        public Amount amount { get; set; }

        [JsonPropertyName("refundedAmount")]
        public RefundedAmount refundedAmount { get; set; }

        [JsonPropertyName("netAmount")]
        public NetAmount netAmount { get; set; }

        [JsonPropertyName("creditCardType")]
        public string creditCardType { get; set; }

        [JsonPropertyName("provider")]
        public string provider { get; set; }

        [JsonPropertyName("refunds")]
        public List<object> refunds { get; set; }

        [JsonPropertyName("processingFees")]
        public List<ProcessingFee> processingFees { get; set; }

        [JsonPropertyName("giftCardId")]
        public object giftCardId { get; set; }

        [JsonPropertyName("paidOn")]
        public DateTime paidOn { get; set; }

        [JsonPropertyName("externalTransactionId")]
        public string externalTransactionId { get; set; }

        [JsonPropertyName("externalTransactionProperties")]
        public List<object> externalTransactionProperties { get; set; }

        [JsonPropertyName("externalCustomerId")]
        public object externalCustomerId { get; set; }
    }
}
