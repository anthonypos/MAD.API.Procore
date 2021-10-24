using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.EmailCommunications.Models
{
    public class Attachment
    {

        /// <summary>
        /// Attachment ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Attachment name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Attachment URL
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }
    }
}
