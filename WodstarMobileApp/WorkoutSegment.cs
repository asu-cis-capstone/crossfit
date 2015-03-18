using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class WorkoutSegment
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty(PropertyName = "segmentType")]
		public String segmentType;

		[JsonProperty(PropertyName = "workoutId")]
		public String workoutId;

		[JsonProperty(PropertyName = "segmentMovements")]
		public Movement[] segmentMovements;

		[JsonProperty(PropertyName = "movementDescriptions")]
		public String[] movementDescriptions;

		[JsonProperty(PropertyName = "segmentHeader")]
		public String segmentHeader;

		[JsonProperty(PropertyName = "segmentDescription")]
		public String segmentDescription;

		[JsonProperty(PropertyName = "repetitions")]
		public int repetitions;

		public WorkoutSegment (String type, String workoutId, 
			String header, String description, int repetitions, 
			String[] movementDescriptions, params Movement[] movements)
		{
			this.segmentType = type;
			this.workoutId = workoutId;
			this.segmentHeader = header;
			this.segmentMovements = movements;
			this.repetitions = repetitions;
			this.movementDescriptions = movementDescriptions;
			this.segmentDescription = description;
		}
	}
}

