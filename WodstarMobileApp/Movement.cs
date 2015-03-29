using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class Movement
	{
		[JsonProperty (PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty (PropertyName = "classification")]
		public String classification { get; set; }

		[JsonProperty (PropertyName = "equipment")]
		public String equipment { get; set; }

		[JsonProperty (PropertyName = "type")]
		public String type { get; set; }

		[JsonProperty (PropertyName = "name")]
		public String name { get; set; }

		[JsonProperty (PropertyName = "rxDescription")]
		public String rxDescription { get; set; }

		[JsonProperty (PropertyName = "blackDiamondDescription")]
		public String blackDiamondDescription { get; set; }

		[JsonProperty (PropertyName = "blueSquareDescription")]
		public String blueSquareDescription { get; set; }

		[JsonProperty (PropertyName = "greenCircleDescription")]
		public String greenCircleDescription { get; set; }

		[JsonProperty (PropertyName = "url")]
		public String url { get; set; }

		//Default constructor
		public Movement ()
		{
			
		}


		public Movement (String name, String url, String type, String equipment)
		{
			this.name = name;
			this.url = url;
			this.type = type;
			this.equipment = equipment;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription)
		{
			this.name = name;
			this.url = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription, String blueSquareDescription)
		{
			this.name = name;
			this.url = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
			this.blueSquareDescription = blueSquareDescription;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription, String blueSquareDescription, String greenCircleDescription)
		{
			this.name = name;
			this.url = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
			this.blueSquareDescription = blueSquareDescription;
			this.greenCircleDescription = greenCircleDescription;
		}
	}
}
