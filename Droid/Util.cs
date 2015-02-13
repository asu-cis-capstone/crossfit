
using System;
using Microsoft.WindowsAzure.MobileServices;

namespace WodstarMobileApp.Droid
{
	public class Util
	{
		public static UserDOM thisUser;
		IMobileServiceTable<WorkoutDOM> workoutTable;
		IMobileServiceTable<UserDOM> userTable;

		public static void initializeTables() {
			workoutTable = MainActivity.MobileService.GetTable<WorkoutDOM>();
			userTable = MainActivity.MobileService.GetTable<UserDOM> ();
		}

	}
}

