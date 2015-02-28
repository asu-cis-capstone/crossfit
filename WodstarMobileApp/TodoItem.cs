using System;
using Newtonsoft.Json;

namespace WodstarMobileApp
{
	public class TodoItem
	{
		//[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "Text")]
		public string Text { get; set; }

		[JsonProperty(PropertyName = "Complete")]
		public bool Complete { get; set; }
	}
}

