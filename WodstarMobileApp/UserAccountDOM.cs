using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class UserAccount
	{
		[JsonProperty(PropertyName = "Id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "Username")]
		public string Username { get; set; }

		[JsonProperty(PropertyName = "AccountType")]
		public string AccountType { get; set; }

		[JsonProperty(PropertyName = "FirstName")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "LastName")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "Gender")]
		public string Gender { get; set; }

		[JsonProperty(PropertyName = "Age")]
		public int Age { get; set; }

		[JsonProperty(PropertyName = "userImage")] 
		public Android.Media.Image userImage { get; set; }

		//Default constructor
		public UserAccount () {

		}
	}
}
