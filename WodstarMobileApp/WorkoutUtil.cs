using System;
using System.Collections.Generic;

namespace WodstarMobileApp
{
	public static class WorkoutUtil
	{
		//Segment types
		public const String amrap = "amrap";
		public const String forTime = "time";
		public const String wodType = "wod";
		public const String prType = "pr";
		public const String strengthType = "strength";

		//Workout types
		public const String camilleType = "camile";
		public const String heroType = "hero";
		public const String benchmarkType = "benchmark";
		public const String wodstarType = "wodstar";

		public static List<Workout> benchmarkWods = new List<Workout>();
		public static List<Workout> heroWods = new List<Workout>();
		public static List<Workout> camilleWods = new List<Workout>();
		public static List<Workout> wodstarWods = new List<Workout>();

		//Initialized by Azure. Name, Id.
		public static Dictionary<string, string> benchmarkIds = new Dictionary<string, string>() {
			{amandaName, amandaId},
			{jackieName, jackieId},
			{kellyName, kellyId},
			{helenName, helenId},
			{karenName, karenId}
		};
		public static Dictionary<string, string> heroIds = new Dictionary<string, string>();
		public static Dictionary<string, string>> camilleIds = new Dictionary<string, string>();
		public static Dictionary<string, string> wodstarIds = new Dictionary<string, string>();

		public static String[] stringBenchmarkWods = new String[] {
			"Amanda", "Jackie", "Kelly", "Helen", "Karen", "Isabel", "Grace", "Fran", "Elizabeth",
			"Diane", "Cindy", "Chelsea", "Annie", "Christine", "Barbara", "Angie", "Mary", "Annie", "Nancy",
			"Nicole", "Linda", "Rosa", "Eva"
		};

		public static String[] stringheroWods = new String[] { "Johnson", "Roy", "RJ", "Luce", "Abbate",
			"The Seven", "McCluskey", "Weaver", "Ledesma", "Wittman", "Rankel", "Holbrook", "Whitten",
			"Bull", "Collin", "Thompson", "Santora", "Bradshaw", "Santiago", "Carse", "Bradley", "Meadows",
			"Gator", "Small", "Moon", "Wilmot", "Lumberjack 20", "Strange", "Nick", "Brian", "Jag 28", "Pheezy",
			"Rahoj", "Desforges", "Paul", "McGhee", "Tyler", "Hansen", "Danny", "DT", "Ryan", "Tommy V", "Garrett",
			"Mr. Joshua", "JT", "Blake", "Moore", "Brenton", "Murph", "Michael", "Daniel", "Josh", "Jason", "Badger",
			"Joshie", "Randy", "Griff", "War Frank", "Jerry", "Nate", "Joshua"
		};
		
		public static String[] canadaHeroWods = new String[] { "Stephen", "Nutts", "Erin" };
		public static String[] australiaHeroWods = new String[] { "Wood" };

		public const string amandaId="1";
		public const string amandaName = "Amanda";
		public const string jackieId="2";
		public const string jackieName = "Jackie";
		public const string kellyId="3";
		public const string kellyName = "Kelly";
		public const string helenId="4";
		public const string helenName = "Helen";
		public const string karenId="5";
		public const string karenName = "Karen";
		public const string isabelId = "6";
		public const string isabelName = "Isabel";
		public const string joshuaId="7";
		public const string joshuaName = "Joshua";
		public const string jerryId="8";
		public const string jerryName = "Jerry";
		public const string warFrankId="9";
		public const string warFrankName = "War Frank";
		public const string garrettId="10";
		public const string garrettName = "Garrett";
		public const string griffId="11";
		public const string griffName = "Griff";
		public const string franName = "Fran";
		public const string franId = "12";
		public const string nicoleName = "Nicole";
		public const string nicoleId = "13";
		public const string graceId = "14";
		public const string elizabethId = "15";
		public const string dianeId = "16";
		public const string cindyId = "17";
		public const string chelseaId = "18";
		public const string annieId = "19";
		public const string christineId = "20";
		public const string barbaraId = "21";
		public const string angieId = "22";
		public const string maryId = "23";
	}
}

