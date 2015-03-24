using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WodstarMobileApp
{
	public class UserJournal
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		[JsonProperty(PropertyName = "userAccountId")]
		public string userAccountId;

		[JsonProperty(PropertyName = "entryType")]
		public string entryType { get; set; }

		[JsonProperty(PropertyName = "statId")]
		public int statId { get; set; }

		[JsonProperty(PropertyName = "statType")]
		public string statType { get; set; }

		[JsonProperty(PropertyName = "statName")]
		public string statName { get; set; }

		[JsonProperty(PropertyName = "statResult")]
		public string statResult { get; set; }

		public List<int> workoutIdsInJournal;


		public UserJournal (string userId, string entryType, int statId, string type, string name, string result)
		{
			this.entryType = entryType;
			this.statId = statId;
			this.userAccountId = userId; 
			this.statType = type;
			this.statName = name;
			this.statResult = result;
		}

		public void addWorkoutData(int workoutId) {
			if (!workoutIdsInJournal.Contains (workoutId)) {
				//Create new entrance for workout Id
			}
			//Add data information to set
		}
	}
}

