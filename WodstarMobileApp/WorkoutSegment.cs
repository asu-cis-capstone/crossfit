using System;

namespace WodstarMobileApp
{
	public class WorkoutSegment
	{
		public String segmentType;
		public Movement[] segmentMovements;
		public String segmentHeader;
		public String segmentDescription;
		public int repetitions = 1;

		public WorkoutSegment (String type, String header, String description, int repetitions, params Movement[] movements)
		{
			this.segmentType = type;
			this.segmentHeader = header;
			this.segmentMovements = movements;
			this.repetitions = repetitions;
			this.segmentDescription = description;
		}
	}
}

