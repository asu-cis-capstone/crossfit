using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class UserJournal
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		[JsonProperty(PropertyName = "userAccountId")]
		public string userAccountId;

		[JsonProperty(PropertyName = "statType")]
		public string statType { get; set; }

		[JsonProperty(PropertyName = "statName")]
		public string statName { get; set; }

		[JsonProperty(PropertyName = "statResult")]
		public string statResult { get; set; }


		public UserJournal ()
		{

		}
	}
}

