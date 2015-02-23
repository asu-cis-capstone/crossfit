using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp
{
	public class Azure
	{
		private static MobileServiceClient azureClient;
		public static UserDOM thisUser;
		private static IMobileServiceTableQuery<UserDOM> userTable;

		public static void initializeAzure() {
			//connect to Azure
			CurrentPlatform.Init();
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "kQKEljOALXgvBQWocFdYxXYaHlfAYB80");
		}//end initializeAzure method

		public static void userAccount(string username) {
			//fetch the user details from the database
			userTable = azureClient.GetTable<UserDOM>().Where(user => user.username == username);

			if (userTable != null) {
				//do nothing yet
			}
		}//end userAccount method
	}
}

