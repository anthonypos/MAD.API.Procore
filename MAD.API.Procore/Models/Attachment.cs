using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Attachment {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// URL
		/// </summary>
		[JsonProperty("url")]		public string Url { get; set; }

		/// <summary>
		/// Filename
		/// </summary>
		[JsonProperty("filename")]		public string Filename { get; set; }
	}
}
