using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models
{
    public class CoordinationIssue
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Unique identifier for the issue. This is auto-generated attribute if not provided during issue creation.
        /// </summary>
        [JsonProperty("uuid")] public string Uuid { get; set; }

        /// <summary>
        /// Coordination Issue title. The title can have a maximum of 80 characters.
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Coordination Issue description.
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Status of the issue.
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Issue Number. A number that can be referred by users to easily identify an issue. Issue number starts from 1 for each project, and is unique per project
        /// </summary>
        [JsonProperty("issue_number")] public int? IssueNumber { get; set; }

        /// <summary>
        /// Coordination Issue can be created from Procore app or a plugin i.e. a source
        /// </summary>
        [JsonProperty("creation_source")] public string CreationSource { get; set; }

        /// <summary>
        /// Due date of the Coordination Issue. Accepted date formats are "yyyy-mm-dd" and "yyyymmdd"
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [JsonProperty("project_id")] public decimal? ProjectId { get; set; }

        /// <summary>
        /// Model ID
        /// </summary>
        [JsonProperty("bim_model_id")] public decimal? BimModelId { get; set; }

        /// <summary>
        /// Count of comments
        /// </summary>
        [JsonProperty("comments_count")] public decimal? CommentsCount { get; set; }

        /// <summary>
        /// Issue type of the Coordination Issue
        /// </summary>
        [JsonProperty("issue_type")] public string IssueType { get; set; }

        /// <summary>
        /// Priority of the Coordination Issue
        /// </summary>
        [JsonProperty("priority")] public string Priority { get; set; }

        /// <summary>
        /// Coordination Issue File
        /// </summary>
        [JsonProperty("coordination_isue_file")] public CoordinationIsueFile CoordinationIsueFile { get; set; }

        [JsonProperty("drawing_revision")] public DrawingRevision DrawingRevision { get; set; }

        [JsonProperty("trade")] public Trade Trade { get; set; }

        /// <summary>
        /// Origin source for a Coordination Issue
        /// </summary>
        [JsonProperty("origin")] public Origin Origin { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        [JsonProperty("assignee")] public Assignee Assignee { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// An array of viewpoints
        /// </summary>
        [JsonProperty("viewpoints")] public List<Viewpoint> Viewpoints { get; set; }

        /// <summary>
        /// An array of attachments
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Procore items linked to Coordination Issue
        /// </summary>
        [JsonProperty("linked_procore_items")] public List<CoordinationIssueProcoreItemAssociationDetail> LinkedProcoreItems { get; set; }

        /// <summary>
        /// Details of drawings linked to Coordination Issue
        /// </summary>
        [JsonProperty("linked_drawings")] public List<CoordinationIssuePinnedPreviewImage> LinkedDrawings { get; set; }

        /// <summary>
        /// Observation Items linked to Coordination Issue
        /// </summary>
        [JsonProperty("linked_observation_items")] public List<CoordinationIssueLinkedObservationItem> LinkedObservationItems { get; set; }

        /// <summary>
        /// Preview images generated by drawings with Coordination Issue Pin
        /// </summary>
        [JsonProperty("drawing_markup_preview_images")] public List<DrawingMarkupPreviewImage> DrawingMarkupPreviewImages { get; set; }

        [JsonProperty("updated_by")] public UpdatedBy UpdatedBy { get; set; }
    }
}
