using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class ProcessingFee
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("amount")]
        public Amount amount { get; set; }

        [JsonPropertyName("amountGatewayCurrency")]
        public AmountGatewayCurrency amountGatewayCurrency { get; set; }

        [JsonPropertyName("exchangeRate")]
        public int exchangeRate { get; set; }

        [JsonPropertyName("refundedAmount")]
        public RefundedAmount refundedAmount { get; set; }

        [JsonPropertyName("refundedAmountGatewayCurrency")]
        public RefundedAmountGatewayCurrency refundedAmountGatewayCurrency { get; set; }

        [JsonPropertyName("netAmount")]
        public NetAmount netAmount { get; set; }

        [JsonPropertyName("netAmountGatewayCurrency")]
        public NetAmountGatewayCurrency netAmountGatewayCurrency { get; set; }

        [JsonPropertyName("feeRefunds")]
        public List<object> feeRefunds { get; set; }
    }
}
