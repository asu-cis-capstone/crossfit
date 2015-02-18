using System;
using Newtonsoft.Json;

namespace WodstarMobileApp.Droid
{
	public class UserDOM
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty(PropertyName = "first_name")]
		public String fName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public String lName { get; set; }

		[JsonProperty(PropertyName = "gender")]
		public String gender { get; set; }

		[JsonProperty(PropertyName = "age")]
		public String age { get; set; }
	}
}
