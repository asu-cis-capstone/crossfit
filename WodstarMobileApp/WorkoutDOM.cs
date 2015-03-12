using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class Workout
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		[JsonProperty(PropertyName = "workoutName")]
		private String workoutName { get; set;}

		[JsonProperty(PropertyName = "workoutType")]
		private String workoutType { get; set;}

		private Movement[] movements { get; set;}

		//Add the cool down/end workout one time sessions
		//Need to have a type for each movement in the array - maybe make jagged array of types?

		public Workout (String name, String type, Movement[] movements)
		{
			this.workoutName = name;
			this.workoutType = type;
			this.movements = movements;
		}

		public Movement[] parseMovements(String movementsFromAzure) {
			//Parse string for 
			return new Movement[1];
		}
	}
}

