using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class UserAccount
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty(PropertyName = "username")]
		public string username { get; set; }

		[JsonProperty(PropertyName = "accountType")]
		public string accountType { get; set; }

		[JsonProperty(PropertyName = "firstName")]
		public string firstName { get; set; }

		[JsonProperty(PropertyName = "lastName")]
		public string lastName { get; set; }

		[JsonProperty(PropertyName = "gender")]
		public string gender { get; set; }

		[JsonProperty(PropertyName = "age")]
		public int age { get; set; }

		[JsonProperty(PropertyName = "userImage")] 
		public Android.Media.Image userImage { get; set; }

		//Default constructor
		public UserAccount () {

		}
	}
}
