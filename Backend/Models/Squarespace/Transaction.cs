
using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Transaction
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime createdOn { get; set; }

        [JsonPropertyName("modifiedOn")]
        public DateTime modifiedOn { get; set; }

        [JsonPropertyName("customerEmail")]
        public string customerEmail { get; set; }

        [JsonPropertyName("salesOrderId")]
        public string salesOrderId { get; set; }

        [JsonPropertyName("voided")]
        public bool voided { get; set; }

        [JsonPropertyName("totalSales")]
        public TotalSales totalSales { get; set; }

        [JsonPropertyName("totalNetSales")]
        public TotalNetSales totalNetSales { get; set; }

        [JsonPropertyName("totalNetShipping")]
        public TotalNetShipping totalNetShipping { get; set; }

        [JsonPropertyName("totalTaxes")]
        public TotalTaxes totalTaxes { get; set; }

        [JsonPropertyName("total")]
        public Total total { get; set; }

        [JsonPropertyName("totalNetPayment")]
        public TotalNetPayment totalNetPayment { get; set; }

        [JsonPropertyName("payments")]
        public List<Payment> payments { get; set; }

        [JsonPropertyName("salesLineItems")]
        public List<SalesLineItem> salesLineItems { get; set; }

        [JsonPropertyName("discounts")]
        public List<object> discounts { get; set; }

        [JsonPropertyName("shippingLineItems")]
        public List<object> shippingLineItems { get; set; }

        [JsonPropertyName("paymentGatewayError")]
        public object paymentGatewayError { get; set; }
    }
}
