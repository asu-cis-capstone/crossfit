using System;
using System.Collections.Generic;

namespace WodstarMobileApp
{
	public static class WorkoutUtil
	{
		//Segment types
		public const String amrapType = "amrap";
		public const String forTimeType = "forTme";
		public const String notForTimeType = "notForTime";
		public const String emomType = "emom";
		public const String wodType = "wod";
		public const String prType = "pr";
		public const String strengthType = "strength";

		//Workout types
		public const String camilleType = "camile";
		public const String heroType = "hero";
		public const String benchmarkType = "benchmark";
		public const String wodstarType = "wodstar";

		public static List<WorkoutSegment> allSegments;

		//Id and full workout
		public static Dictionary<string, Workout> benchmarkWods = new Dictionary<string, Workout>();
		public static Dictionary<string, Workout> heroWods = new Dictionary<string, Workout>();
		public static Dictionary<string, Workout> camilleWods = new Dictionary<string, Workout>();
		public static Dictionary<string, Workout> wodstarWods = new Dictionary<string, Workout>();

		//Initialized by Azure. Name, Id.
		public static Dictionary<string, string> benchmarkIds = new Dictionary<string, string>();
		public static Dictionary<string, string> heroIds = new Dictionary<string, string>();
		public static Dictionary<string, string> camilleIds = new Dictionary<string, string>();
		public static Dictionary<string, string> wodstarIds = new Dictionary<string, string>();

		public static String[] stringBenchmarkWods = new String[] {
			amandaName, jackieName, kellyName, helenName, karenName, isabelName, graceName, franName, elizabethName,
			dianeName, cindyName, chelseaName, annieName, christineName, barbaraName, angieName, maryName, annieName, nancyName,
			nicoleName, lindaName, rosaName, evaName
		};

		public static String[] stringHeroWods = new String[] { johnsonName, royName, rjName, luceName, abbateName,
			theSevenName, "McCluskey", "Weaver", "Ledesma", "Wittman", "Rankel", "Holbrook", "Whitten",
			"Bull", "Collin", "Thompson", "Santora", "Bradshaw", "Santiago", "Carse", "Bradley", "Meadows",
			"Gator", "Small", "Moon", "Wilmot", "Lumberjack 20", "Strange", "Nick", "Brian", "Jag 28", "Pheezy",
			"Rahoj", "Desforges", "Paul", "McGhee", "Tyler", "Hansen", "Danny", "DT", "Ryan", "Tommy V", "Garrett",
			"Mr. Joshua", "JT", "Blake", "Moore", "Brenton", "Murph", "Michael", "Daniel", "Josh", "Jason", "Badger",
			joshieName, randyName, griffName, warFrankName, jerryName, nateName, joshuaName
		};
		
		public static String[] canadaHeroWods = new String[] { "Stephen", "Nutts", "Erin" };
		public static String[] australiaHeroWods = new String[] { "Wood" };

		public const string johnsonName = "Johnson";
		public const string royName = "Roy";
		public const string rjName = "RJ";
		public const string luceName = "Luce";
		public const string abbateName = "Abbate";
		public const string theSevenName = "The Seven";
		public const string joshieName = "Joshie";
		public const string randyName = "Randy";
		public const string nateName = "Nate";
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
		public const string graceName = "Grace";
		public const string elizabethId = "15";
		public const string elizabethName = "Elizabeth";
		public const string dianeId = "16";
		public const string dianeName = "Diane";
		public const string cindyId = "17";
		public const string cindyName = "Cindy";
		public const string chelseaId = "18";
		public const string chelseaName = "Chelsea";
		public const string annieId = "19";
		public const string annieName = "Annie";
		public const string christineId = "20";
		public const string christineName = "Christine";
		public const string barbaraId = "21";
		public const string barbaraName = "Barbara";
		public const string angieId = "22";
		public const string angieName = "Angie";
		public const string maryId = "23";
		public const string maryName = "Mary";
		public const string nancyName = "Nancy";
		public const string nancyId = "24";
		public const string evaName = "Eva";
		public const string evaId = "25";
		public const string lindaName = "Linda";
		public const string lindaId = "26";
		public const string rosaId = "27";
		public const string rosaName = "Rosa";
	}
}

