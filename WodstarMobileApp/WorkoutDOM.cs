using System;

namespace WodstarMobileApp
{
	public class Workout
	{
		private String workoutName { get; set;}
		private String workoutType { get; set;}
		private Movement[] movements { get; set;}

		//Add the cool down/end workout one time sessions
		//Need to have a type for each movement in the array - maybe make jagged array of types?

		public Workout (String name, String type)
		{
			this.workoutName = name;
			this.workoutType = type;
		}
	}
}

