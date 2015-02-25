using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp
{
	public static class Azure
	{
		private static MobileServiceClient azureClient;
		public static Users thisUser;
		private static IMobileServiceTableQuery<Users> userTable;

		public static void initializeAzure() {
			//connect to Azure
			CurrentPlatform.Init();
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "kQKEljOALXgvBQWocFdYxXYaHlfAYB80");
		}//end initializeAzure method

		public static void userAccount(string username) {
			//fetch the user details from the database
			userTable = azureClient.GetTable<Users>().Where(user => user.username == username);

			if (userTable != null) {
				//do nothing yet
			}
		}//end userAccount method

/*		public static WorkoutDOM getWorkout(string id) {
			return new WorkoutDOM ();
		}

		public static MovementDOM getMovement(string id) {
			return new MovementDOM ();
		} */
	}
}

