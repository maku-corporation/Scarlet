
using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class TransactionItems
    {
        [JsonPropertyName("documents")]
        public List<Transaction> transactions { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination pagination { get; set; }
    }
}
