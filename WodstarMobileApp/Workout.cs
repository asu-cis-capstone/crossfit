using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class Workout
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		//The workout name
		[JsonProperty(PropertyName = "workoutName")]
		public String workoutName { get; set;}

		//The type; benchmark, hero, camille, wodstar
		[JsonProperty(PropertyName = "workoutType")]
		public String workoutType { get; set;}
	
		public Workout (String name, String type) {
			this.workoutName = name;
			this.workoutType = type;
		}

		//Default constructor
		public Workout () {

		}
	}
}

