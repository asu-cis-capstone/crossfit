using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

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

		//TODO: Add all the navigation methods here between screens


	}
}

