using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Order
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("orderNumber")]
        public string orderNumber { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime createdOn { get; set; }

        [JsonPropertyName("modifiedOn")]
        public DateTime modifiedOn { get; set; }

        [JsonPropertyName("channel")]
        public string channel { get; set; }

        [JsonPropertyName("testmode")]
        public bool testmode { get; set; }

        [JsonPropertyName("customerEmail")]
        public string customerEmail { get; set; }

        [JsonPropertyName("billingAddress")]
        public BillingAddress billingAddress { get; set; }

        [JsonPropertyName("shippingAddress")]
        public object shippingAddress { get; set; }

        [JsonPropertyName("fulfillmentStatus")]
        public string fulfillmentStatus { get; set; }

        [JsonPropertyName("lineItems")]
        public List<LineItem> lineItems { get; set; }

        [JsonPropertyName("internalNotes")]
        public List<object> internalNotes { get; set; }

        [JsonPropertyName("shippingLines")]
        public List<object> shippingLines { get; set; }

        [JsonPropertyName("discountLines")]
        public List<object> discountLines { get; set; }

        [JsonPropertyName("formSubmission")]
        public List<FormSubmission> formSubmission { get; set; }

        [JsonPropertyName("fulfillments")]
        public List<Fulfillment> fulfillments { get; set; }

        [JsonPropertyName("subtotal")]
        public Subtotal subtotal { get; set; }

        [JsonPropertyName("shippingTotal")]
        public ShippingTotal shippingTotal { get; set; }

        [JsonPropertyName("discountTotal")]
        public DiscountTotal discountTotal { get; set; }

        [JsonPropertyName("taxTotal")]
        public TaxTotal taxTotal { get; set; }

        [JsonPropertyName("refundedTotal")]
        public RefundedTotal refundedTotal { get; set; }

        [JsonPropertyName("grandTotal")]
        public GrandTotal grandTotal { get; set; }

        [JsonPropertyName("channelName")]
        public string channelName { get; set; }

        [JsonPropertyName("externalOrderReference")]
        public object externalOrderReference { get; set; }

        [JsonPropertyName("fulfilledOn")]
        public DateTime? fulfilledOn { get; set; }

        [JsonPropertyName("priceTaxInterpretation")]
        public string priceTaxInterpretation { get; set; }
    }
}
