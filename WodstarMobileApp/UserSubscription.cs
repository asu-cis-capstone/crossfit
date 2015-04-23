using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class UserSubscription
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty(PropertyName = "userAccountId")]
		public string userAccountId { get; set; }

		[JsonProperty(PropertyName = "subName")]
		public String subName { get; set; }

		[JsonProperty(PropertyName = "subStartDate")]
		public DateTime subStartDate { get; set; }

		[JsonProperty(PropertyName = "subEndDate")]
		public DateTime subEndDate { get; set; }

		//Default constructor
		public UserSubscription ()
		{
		}
	}
}

