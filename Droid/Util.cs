using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp.Droid
{
	public class Util
	{
		private static MobileServiceClient azureClient;
		public static UserDOM thisUser;
		private static IMobileServiceTable<UserDOM> userTable;

		public static void initializeTables() {
			//connect to Azure
			CurrentPlatform.Init();
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "kQKEljOALXgvBQWocFdYxXYaHlfAYB80");

			userTable = azureClient.GetTable<UserDOM>();

		}

	}
}

