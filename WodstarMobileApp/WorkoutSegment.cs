using System;

namespace WodstarMobileApp
{
	public class WorkoutSegment
	{
		public String segmentType;
		public String workoutId;
		public Movement[] segmentMovements;
		public String[] movementDescriptions;
		public String segmentHeader;
		public String segmentDescription;
		public int repetitions = 1;

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

