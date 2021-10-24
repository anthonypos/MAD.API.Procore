using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class PotentialDistribution
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Does contact have specified access for project
        /// </summary>
        [JsonProperty("valid")] public bool Valid { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Vendor attributes
        /// </summary>
        [JsonProperty("company")] public Company Company { get; set; }
    }
}
