using System;
using Newtonsoft.Json;
using System.Collections.Generic;

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
		                       String movementDescriptions, String movements)
		{
			this.segmentType = type;
			this.workoutId = workoutId;
			this.segmentHeader = header;
			this.segmentMovements = movements;
			this.repetitions = repetitions;
			this.movementDescriptions = movementDescriptions;
			this.segmentDescription = description;
		}

		public void parseMovements() {
			String[] movementIds = segmentMovements.Split(',');
			List<Movement> movementList = new List<Movement>();
			for(int i = 0; i <movementIds.Length; i++) {
				if(MovementLinks.movementDictionary.ContainsKey(movementIds[i].Trim())) {
					Console.WriteLine("Movement key found in dictionary");
					movementList.Add(MovementLinks.movementDictionary[movementIds[i].Trim()]);
				} else {
					Console.WriteLine("Movement key not found : " + movementIds[i]);
				}
			}
			this.movementDescriptionsArray = movementDescriptions.Split (',');
			Console.WriteLine ("This Segment has " + movementDescriptionsArray.Length + " descriptions.");
			this.segmentMovementsArray = movementList.ToArray ();
			Console.WriteLine ("This segment has " + segmentMovementsArray.Length + " movements");
		}



	}
}

