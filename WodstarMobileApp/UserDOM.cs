using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class User
	{
		[JsonProperty(PropertyName = "id")]
		public int id { get; set; }

		[JsonProperty(PropertyName = "userImage")] 
		public Android.Media.Image userImage { get; set; }

		[JsonProperty(PropertyName = "username")]
		public string username { get; set; }

		[JsonProperty(PropertyName = "account_type")]
		public string accountType { get; set; }

		[JsonProperty(PropertyName = "first_name")]
		public string firstName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string lastName { get; set; }

		[JsonProperty(PropertyName = "gender")]
		public string gender { get; set; }

		[JsonProperty(PropertyName = "age")]
		public string age { get; set; }

		public User() {

		}
	}
}
