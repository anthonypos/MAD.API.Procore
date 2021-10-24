using MAD.API.Procore.Endpoints.FormsUsers.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.FormsUsers
{
    public class ListFormsUsersRequest : ProcoreRequest<ListFormsUsersRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/forms/users"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
