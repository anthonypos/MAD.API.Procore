using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models
{
    public class SubmittalPackage
    {

        [JsonProperty("attachments_count")] public int? AttachmentsCount { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        [JsonProperty("submittal_ids")] public List<long> SubmittalIds { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("number")] public string Number { get; set; }

        [JsonProperty("title")] public string Title { get; set; }
    }
}