﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WodstarMobileApp
{
	public class UserJournal : Java.Lang.Object
	{
		[JsonProperty(PropertyName = "id")]
		public string id { get; set; }

		[JsonProperty(PropertyName = "userAccountId")]
		public String userAccountId { get; set; }

		[JsonProperty(PropertyName = "entryType")]
		public string entryType { get; set; }

		[JsonProperty(PropertyName = "statId")]
		public string statId { get; set; }

		[JsonProperty(PropertyName = "statType")]
		public string statType { get; set; }

		[JsonProperty(PropertyName = "statName")]
		public string statName { get; set; }

		[JsonProperty(PropertyName = "statResult")]
		public string statResult { get; set; }

		[JsonProperty(PropertyName = "statDateTime")]
		public DateTime statDateTime { get; set; }

		public Java.Util.Calendar cal;
		//Default constructor
		public UserJournal () {

		}

		public UserJournal (string userId, string entryType, string statId, string type, string name, string result, DateTime time)
		{
			this.entryType = entryType;
			this.statId = statId;
			this.userAccountId = userId; 
			this.statType = type;
			this.statName = name;
			this.statResult = result;
			this.statDateTime = time;
		}

		public UserJournal (string userId, string entryType, string statId, string type, string name, string result, Java.Util.Calendar date)
		{
			this.entryType = entryType;
			this.statId = statId;
			this.userAccountId = userId; 
			this.statType = type;
			this.statName = name;
			this.statResult = result;
			this.cal = date;
		}
	}
}

