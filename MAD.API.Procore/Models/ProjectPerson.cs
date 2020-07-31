using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectPerson {

		/// <summary>
		/// The Contact associated to the Project Person
		/// </summary>
		[JsonProperty("contact")]		public Contact Contact { get; set; }

		/// <summary>
		/// Project Person employee id
		/// </summary>
		[JsonProperty("employee_id")]		public string? EmployeeId { get; set; }

		/// <summary>
		/// Project Person first name
		/// </summary>
		[JsonProperty("first_name")]		public string FirstName { get; set; }

		/// <summary>
		/// Project Person id
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Project Person employee status
		/// </summary>
		[JsonProperty("is_employee")]		public bool? IsEmployee { get; set; }

		/// <summary>
		/// Project Person last name
		/// </summary>
		[JsonProperty("last_name")]		public string LastName { get; set; }

		/// <summary>
		/// The User ID if this Person represents a User. NULL for a Reference User.
		/// </summary>
		[JsonProperty("user_id")]		public int? UserId { get; set; }

		/// <summary>
		/// Company Person work classification id
		/// </summary>
		[JsonProperty("work_classification_id")]		public int? WorkClassificationId { get; set; }
	}
}
