using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class InspectionType {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}
