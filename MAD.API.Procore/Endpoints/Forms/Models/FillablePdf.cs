using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Forms.Models {
	public class FillablePdf {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// URL
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }

		/// <summary>
		/// Filename
		/// </summary>
		[JsonProperty("filename")]	public  string Filename { get ; set; }

		/// <summary>
		/// Filename
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
