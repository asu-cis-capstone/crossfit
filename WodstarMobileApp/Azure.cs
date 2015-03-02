using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp
{
	public static class Azure
	{
		private static MobileServiceClient azureClient;
		//public static UserAccount thisUser;
		private static IMobileServiceTable<UserAccount> userAccountTable;

		public static void InitializeAzure() {
			//connect to Azure
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "kQKEljOALXgvBQWocFdYxXYaHlfAYB80");
			CurrentPlatform.Init();
		}//end initializeAzure method

		public async static void GetUserAccount(UserAccount thisUser) {
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount>();

			//Query the UserAccount table for the logged in user
			List<UserAccount> users = await userAccountTable
				.Where(u => u.Username == thisUser.Username)
				.Where(u => u.AccountType == thisUser.AccountType)
				.ToListAsync();

			//Create the record in UserAccount table if no records are found
			if (users.Count == 0) {
				CreateUserAccount (thisUser);
			//Otherwise populate thisUser object with the fetched details
			} else {
				thisUser.Id = users [0].Id;
				thisUser.Gender = users [0].Gender;
				thisUser.Age = users [0].Age;
			}
		}//end userAccount method

		public async static void CreateUserAccount(UserAccount thisUser) {
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount>();

			//Insert new record
			await userAccountTable.InsertAsync(thisUser);

			//Call GetUserAccount to fetch the Id from Azure
			GetUserAccount (thisUser);
		}

/*		public static WorkoutDOM getWorkout(string id) {
			return new WorkoutDOM ();
		}

		public static MovementDOM getMovement(string id) {
			return new MovementDOM ();
		} */
	}
}

