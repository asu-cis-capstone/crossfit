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

		[JsonProperty(PropertyName = "userJournal")]
		public UserJournal journal { get; set; }

		//Default constructor
		public UserAccount (string id, string username, string type, string fName, string lName, string gender, int age) {
			this.Id = id;
			this.Username = username;
			this.AccountType = type;
			this.FirstName = fName;
			this.LastName = lName;
			this.Gender = gender;
			this.Age = age;
		}

		public UserAccount() {

		}
	}
}
