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

		[JsonProperty (PropertyName = "name")]
		public String name { get; set; }

		[JsonProperty (PropertyName = "equipment")]
		public String equipment { get; set; }

		[JsonProperty (PropertyName = "type")]
		public String type { get; set; }

		[JsonProperty (PropertyName = "blackDiamondDescription")]
		public String blackDiamondDescription { get; set; }

		[JsonProperty (PropertyName = "blueSquareDescription")]
		public String blueSquareDescription { get; set; }

		[JsonProperty (PropertyName = "greenCircleDescription")]
		public String greenCircleDescription { get; set; }

		[JsonProperty (PropertyName = "rxVideoUrl")]
		public String rxVideoUrl { get; set; }

		[JsonProperty (PropertyName = "rxImageUrl")]
		public String rxImageUrl { get; set; }

		[JsonProperty (PropertyName = "blackDiamondVideoUrl")]
		public String blackDiamondVideoUrl { get; set; }

		[JsonProperty (PropertyName = "blackDiamondImageUrl")]
		public String blackDiamondImageUrl { get; set; }

		[JsonProperty (PropertyName = "blueSquareVideoUrl")]
		public String blueSquareVideoUrl { get; set; }

		[JsonProperty (PropertyName = "blueSquareImageUrl")]
		public String blueSquareImageUrl { get; set; }

		[JsonProperty (PropertyName = "greenCircleVideoUrl")]
		public String greenCircleVideoUrl { get; set; }

		[JsonProperty (PropertyName = "greenCircleImageUrl")]
		public String greenCircleImageUrl { get; set; }


		//Default constructor
		public Movement ()
		{
			
		}


		public Movement (String name, String url, String type, String equipment)
		{
			this.name = name;
			this.rxVideoUrl = url;
			this.type = type;
			this.equipment = equipment;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription)
		{
			this.name = name;
			this.rxVideoUrl = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription, String blueSquareDescription)
		{
			this.name = name;
			this.rxVideoUrl = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
			this.blueSquareDescription = blueSquareDescription;
		}

		public Movement (String name, String url, String type, String equipment, String blackDiamondDescription, String blueSquareDescription, String greenCircleDescription)
		{
			this.name = name;
			this.rxVideoUrl = url;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondDescription = blackDiamondDescription;
			this.blueSquareDescription = blueSquareDescription;
			this.greenCircleDescription = greenCircleDescription;
		}
	}
}
