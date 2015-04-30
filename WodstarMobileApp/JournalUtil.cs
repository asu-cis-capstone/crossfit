using System;
using System.Collections.Generic;
using WodstarMobileApp.Droid;

namespace WodstarMobileApp
{
	public class JournalUtil
	{
		public static List<UserJournal> wodJournalData;
		public static List<UserJournal> prJournalData;

		//Wod vs Movement for Entry Type
		public const string wodType = "wodType";
		public const string prType = "prType";

		//For Stat type for WODs 
		public const string amrapType = "amrap";
		public const string timeType = "time";

		public static void initializeDemoJournalData() {
			prJournalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[3].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "60", System.DateTime.Now));
			prJournalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[3].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "47", System.DateTime.Now.AddDays(1)));
			prJournalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[3].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "71", System.DateTime.Now.AddDays(2)));
			prJournalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[25].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "85", System.DateTime.Now.AddDays(3)));
			prJournalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[25].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "80", System.DateTime.Now.AddDays(4)));
		}

		public static void logForTimeData(Workout thisWorkout, String result) {
			UserJournal newJournalEntry = new UserJournal();
			newJournalEntry.statType = JournalUtil.wodType;
			newJournalEntry.statName = thisWorkout.workoutName;
			newJournalEntry.statType = JournalUtil.timeType;
			newJournalEntry.statName = thisWorkout.workoutName;
			newJournalEntry.entryType = JournalUtil.wodType;
			newJournalEntry.statDateTime = DateTime.Now;
			newJournalEntry.statId = thisWorkout.id;
			newJournalEntry.userAccountId = Util.thisUser.id;
			//Convert timer string into milliseconds.
			char[] delims = {' ', ':', '.'};
			String[] timeEntries = result.Split (delims);
			int minutes = Int32.Parse (timeEntries [0]);
			int seconds = Int32.Parse (timeEntries [1]);
			int milliseconds = Int32.Parse (timeEntries [2]) * 100;
			TimeSpan ts = new TimeSpan (0, 0, minutes, seconds, milliseconds);
			Console.WriteLine ("Time Span recorded as: " + ts.ToString ());
			newJournalEntry.statResult = ts.TotalMilliseconds.ToString ();

			Azure.CreateUserJournal (Util.thisUser, newJournalEntry);
			JournalUtil.wodJournalData.Add (newJournalEntry);
		}
	}
}

