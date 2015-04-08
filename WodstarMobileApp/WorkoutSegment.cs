using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class WorkoutSegment
	{
		[JsonProperty (PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty (PropertyName = "segmentType")]
		public String segmentType;

		[JsonProperty (PropertyName = "workoutId")]
		public String workoutId;

		[JsonProperty (PropertyName = "segmentMovements")]
		public String segmentMovements;
		public Movement[] segmentMovementsArray;

		[JsonProperty (PropertyName = "movementDescriptions")]
		public String movementDescriptions;
		public String[] movementDescriptionsArray;

		[JsonProperty (PropertyName = "segmentHeader")]
		public String segmentHeader;

		[JsonProperty (PropertyName = "segmentDescription")]
		public String segmentDescription;

		[JsonProperty (PropertyName = "repetitions")]
		public int repetitions;

		[JsonProperty (PropertyName = "time")]
		public int time;

		//Default constructor
		public WorkoutSegment ()
		{

		}

		public WorkoutSegment (String type, String workoutId, 
		                       String header, String description, int repetitions, 
		                       String[] movementDescriptions, params Movement[] movements)
		{
			this.segmentType = type;
			this.workoutId = workoutId;
			this.segmentHeader = header;
			this.segmentMovementsArray = movements;
			this.repetitions = repetitions;
			this.movementDescriptionsArray = movementDescriptions;
			this.segmentDescription = description;
		}



	}
}

