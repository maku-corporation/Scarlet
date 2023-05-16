using System.Text.Json.Serialization;

namespace Models.Squarespace
{
    public class Pagination
    {
        [JsonPropertyName("nextPageUrl")]
        public string nextPageUrl;

        [JsonPropertyName("nextPageCursor")]
        public string nextPageCursor;

        [JsonPropertyName("hasNextPage")]
        public string hasNextPage;
    }
}
