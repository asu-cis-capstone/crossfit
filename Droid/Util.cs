
using System;
using Microsoft.WindowsAzure.MobileServices;

namespace WodstarMobileApp.Droid
{
	public class Util
	{
		//TODO: initialize this as user after successful login
		//TODO: encapsulate this data better.
		private static UserDOM thisUser;

		static IMobileServiceTable<WorkoutDOM> workoutTable;
		static IMobileServiceTable<UserDOM> userTable;

		//TODO: create getters and settters for appropriate user variables.

		public static void initializeTables() {
			//workoutTable = MainActivity.MobileService.GetTable<WorkoutDOM>();
			//userTable = MainActivity.MobileService.GetTable<UserDOM> ();
		}

	}
}

