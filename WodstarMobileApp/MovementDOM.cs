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
		public Uri rxLink { get; set;}

		[JsonProperty(PropertyName = "blackDiamondName")]
		public String blackDiamondName { get; set;}

		[JsonProperty(PropertyName = "blackDiamondLink")]
		public Uri blackDiamondLink { get; set;}

		[JsonProperty(PropertyName = "blueSquareName")]
		public String blueSquareName{ get; set;}

		[JsonProperty(PropertyName = "blueSquareLink")]
		public Uri blueSquareLink{ get; set;}

		[JsonProperty(PropertyName = "greenCircleName")]
		public String greenCircleName{ get; set;}

		[JsonProperty(PropertyName = "greenCircleLink")]
		public Uri greenCircleLink { get; set;}

		public Movement (String rxName, Uri rxLink, String blueDiamondName, Uri blueDiamondLink)
		{
			this.rxName = rxName;
			this.rxLink = rxLink;
		}
	}
}
