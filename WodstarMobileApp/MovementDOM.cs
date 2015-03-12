using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class Movement
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set;}

		[JsonProperty(PropertyName = "classification")]
		public String classification { get; set;}

		[JsonProperty(PropertyName = "equipment")]
		public String equipment { get; set;}

		[JsonProperty(PropertyName = "type")]
		public String type { get; set;}

		[JsonProperty(PropertyName = "rxName")]
		public String rxName { get; set;}

		[JsonProperty(PropertyName = "rxLink")]
		public String rxLink { get; set;}

		[JsonProperty(PropertyName = "blackDiamondName")]
		public String blackDiamondName { get; set;}

		[JsonProperty(PropertyName = "blackDiamondLink")]
		public String blackDiamondLink { get; set;}

		[JsonProperty(PropertyName = "blueSquareName")]
		public String blueSquareName{ get; set;}

		[JsonProperty(PropertyName = "blueSquareLink")]
		public String blueSquareLink{ get; set;}

		[JsonProperty(PropertyName = "greenCircleName")]
		public String greenCircleName{ get; set;}

		[JsonProperty(PropertyName = "greenCircleLink")]
		public String greenCircleLink { get; set;}

		public Movement(String rxName, String rxLink, String type, String equipment) {
			this.rxName = rxName;
			this.rxLink = rxLink;
			this.type = type;
			this.equipment = equipment;
		}

		public Movement (String rxName, String rxLink, String type, String equipment, String blackDiamondName, String blackDiamondLink)
		{
			this.rxName = rxName;
			this.rxLink = rxLink;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondName = blackDiamondName;
			this.blackDiamondLink = blackDiamondLink;
		}

		public Movement (String rxName, String rxLink, String type, String equipment, String blackDiamondName, String blackDiamondLink, String blueSquareName, String blueSquareLink)
		{
			this.rxName = rxName;
			this.rxLink = rxLink;
			this.type = type;
			this.equipment = equipment;
			this.blackDiamondName = blackDiamondName;
			this.blackDiamondLink = blackDiamondLink;
			this.blueSquareLink = blueSquareLink;
			this.blueSquareName = blueSquareName;
		}

		public Movement (String rxName, String rxLink, String type, String equipment, String blackDiamondName, String blackDiamondLink, String blueSquareName, String blueSquareLink, String greenCircleName, String greenCircleLink)
		{
			this.rxName = rxName;
			this.rxLink = rxLink;
			this.type = type;
			this.equipment = equipment;
			this.blueSquareLink = blueSquareLink;
			this.blueSquareName = blueSquareName;
			this.greenCircleLink = greenCircleLink;
			this.greenCircleName = greenCircleName;
		}
	}
}
