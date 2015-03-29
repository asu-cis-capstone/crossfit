﻿using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp
{
	public static class Azure
	{
		private static MobileServiceClient azureClient;
		private static IMobileServiceTable<UserAccount> userAccountTable;
		private static IMobileServiceTable<Workout> workoutTable;
		public static List<Workout> workouts;

		public static void InitializeAzure() {
			//connect to Azure
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66");
			CurrentPlatform.Init();
		}//end initializeAzure method

		//Query UserAccount table for the authenticated user
		public async static void GetUserAccount(UserAccount thisUser) {
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount>();

			//Query the UserAccount table for the logged in user
			List<UserAccount> users = await userAccountTable
				.Where(u => u.username == thisUser.username)
				.Where(u => u.accountType == thisUser.accountType)
				.ToListAsync();

			//Create the record in UserAccount table if no records are found
			if (users.Count == 0) {
				CreateUserAccount (thisUser);
			//Otherwise populate thisUser object with the fetched details
			} else {
				thisUser.id = users [0].id;
				thisUser.gender = users [0].gender;
				thisUser.age = users [0].age;
			}
		}//end UserAccount method

		//Create UserAccount record, called automatically by GetUserAccount when no account exists
		public async static void CreateUserAccount(UserAccount thisUser) {
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount>();

			//Insert new record
			await userAccountTable.InsertAsync(thisUser);

			//Call GetUserAccount to fetch the Id for the newly created UserAccount record
			GetUserAccount (thisUser);
		}//end CreateUserAccount method

		public async static void GetWorkouts() {
			//Set UserAccount table object
			workoutTable = azureClient.GetTable<Workout>();

			//Query the Workout table for all workouts
			workouts = await workoutTable
				.ToListAsync();

			//Debug output to the console
			Console.WriteLine("DEBUG - GetWorkouts");
			foreach (var workout in workouts) {
				Console.WriteLine (string.Format ("ID: {0}\nName: {1}\nType: {2}", workout.id, workout.workoutName, workout.workoutType));
			}
		}//end GetWorkouts method


	}
}

