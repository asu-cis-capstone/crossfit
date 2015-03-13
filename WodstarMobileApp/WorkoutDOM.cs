using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class Workout
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		[JsonProperty(PropertyName = "workoutName")]
		public String workoutName { get; set;}

		[JsonProperty(PropertyName = "workoutType")]
		public String workoutType { get; set;}

		public WorkoutSegment[] segments;

		//Add the cool down/end workout one time sessions
		//Need to have a type for each movement in the array - maybe make jagged array of types?

		public Workout (String name, params WorkoutSegment[] segments)
			this.workoutName = name;
			this.segments = segments;
		}

		public Movement[] parseMovements(String movementsFromAzure) {
			//Parse string for commas
			return new Movement[0];
		}
	}
}

