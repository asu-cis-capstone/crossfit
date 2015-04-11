using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace WodstarMobileApp
{
	public static class Azure
	{
		//class variables
		private static MobileServiceClient azureClient;
		private static IMobileServiceTable<UserAccount> userAccountTable;
		private static IMobileServiceTable<Workout> workoutTable;
		public static List<Workout> workouts;
		private static IMobileServiceTable<WorkoutSegment> workoutSegmentTable;
		public static List<WorkoutSegment> workoutSegments;
		private static IMobileServiceTable<Movement> movementTable;
		public static List<Movement> movements;
		private static IMobileServiceTable<UserJournal> userJournalTable;
		public static List<UserJournal> userJournals;


		//Initialize connection to Azure Mobile Service
		public static void InitializeAzure ()
		{
			try {
				Console.WriteLine ("InitializeAzure method called");
				//connect to Azure
				azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66");
				Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);
				CurrentPlatform.Init ();
				//DB connect test
				Console.WriteLine ("Azure initialization successful");
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.InitializeAzure(): " + e);
			}
		}//end initializeAzure method

		//Query UserAccount table for the authenticated user
		public async static void GetUserAccount (UserAccount thisUser)
		{
			try {
				Console.WriteLine ("Azure GetUserAccount method called");
				//Set UserAccount table object
				userAccountTable = azureClient.GetTable<UserAccount> ();

				//Query the UserAccount table for the logged in user
				List<UserAccount> users = await userAccountTable
					.Where (u => u.username == thisUser.username)
					.Where (u => u.accountType == thisUser.accountType)
					.ToListAsync ();

				//Create the record in UserAccount table if no records are found
				if (users.Count == 0) {
					Console.WriteLine ("No user account found, calling CreateUserAccount method");
					CreateUserAccount (thisUser);
				//Otherwise populate thisUser object with the fetched details
				} else {
					Console.WriteLine ("User account found, populating details");
					thisUser.id = users [0].id;
					thisUser.gender = users [0].gender;
					thisUser.age = users [0].age;

					//fetch user's journals from Azure
					GetUserJournals (thisUser);
				}
				Console.WriteLine ("Azure GetUserAccount method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during GetUserAccount(), retrying connection to Azure");
				GetUserAccount (thisUser);
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.GetUserAccount(): " + e);
			}
		}//end GetUserAccount method

		//Create UserAccount record, called automatically by GetUserAccount when no account exists
		public async static void CreateUserAccount (UserAccount thisUser)
		{
			try {
				Console.WriteLine ("CreateUserAccount method called");
				//Set UserAccount table object
				userAccountTable = azureClient.GetTable<UserAccount> ();

				//Insert new record
				Console.WriteLine ("Inserting new user into Azure database");
				await userAccountTable.InsertAsync (thisUser);

				//Call GetUserAccount to fetch the Id for the newly created UserAccount record
				GetUserAccount (thisUser);
				Console.WriteLine ("CreateUserAccount method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during CreateUserAccount(), retrying connection to Azure");
				CreateUserAccount (thisUser);
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.CreateUserAccount(): " + e);
			}
		}//end CreateUserAccount method

		//Query Workout table for all workouts
		public async static void GetWorkouts ()
		{
			try {
				Console.WriteLine ("GetWorkouts method called");

				//Set Workouts table object
				workoutTable = azureClient.GetTable<Workout> ();

				//Fetch all workouts into a List
				Console.WriteLine("Getting workouts from Azure");
				workouts = await workoutTable.ToListAsync ();

				//Debug output to the console
				Console.WriteLine ("DEBUG - GetWorkouts");
				foreach (var workout in workouts) {				
					if (workouts != null) {
						Console.WriteLine (string.Format ("ID: {0}\nName: {1}\nType: {2}", workout.id, workout.workoutName, workout.workoutType));
					}
				}

				Console.WriteLine ("GetWorkouts method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during GetWorkouts(), retrying connection to Azure");
				GetWorkouts ();
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.GetWorkouts(): " + e);
			}
		}//end GetWorkouts method

		//Query WorkoutSegment table for all workout segments
		public async static void GetWorkoutSegments ()
		{
			try {
				Console.WriteLine ("GetWorkoutSegments method called");
				//Set WorkoutSegments table object
				workoutSegmentTable = azureClient.GetTable<WorkoutSegment> ();

				//Fetch all workout segments into a List
				Console.WriteLine("Fetching workout segments from Azure");
				workoutSegments = await workoutSegmentTable
					.ToListAsync ();

				//Debug output to the console
				Console.WriteLine ("DEBUG - GetWorkoutSegments");
				if (workoutSegments != null) {
					foreach (var segment in workoutSegments) {
						Console.WriteLine (string.Format ("ID: {0}\nWorkout: {1}\nType: {2}", segment.id, segment.workoutId, segment.segmentType));
					}
				}

				Console.WriteLine ("GetWorkoutSegments method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during GetWorkoutSegments(), retrying connection to Azure");
				GetWorkoutSegments ();
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.GetWorkoutSegments(): " + e);
			}
		}//end GetWorkoutSegments method

		//Query Movements table for all movements
		public async static void GetMovements ()
		{
			try {
				Console.WriteLine ("GetMovements method called");
				//Set Movements table object
				movementTable = azureClient.GetTable<Movement> ();

				//Fetch all movements into a List
				Console.WriteLine("Fetching data from Azure");
				movements = await movementTable.ToListAsync ();

				//Debug output to the console
				Console.WriteLine ("DEBUG - Movements");
				foreach (var movement in movements) {
					Console.WriteLine (string.Format ("ID: {0}\nName: {1}", movement.id, movement.name));
				}

				Console.WriteLine ("GetMovements method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during GetMovements(), retrying connection to Azure");
				GetMovements ();
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.GetMovements(): " + e);
			}
		}//end GetMovements method

		//Query UserJournal table for this user's journal entries
		public async static void GetUserJournals (UserAccount thisUser)
		{
			try {
				Console.WriteLine ("GetUserJournals method called");
				//Set UserJournal table object
				userJournalTable = azureClient.GetTable<UserJournal> ();

				//Fetch all of this user's journals into a List
				Console.WriteLine("Fetching user's journals from Azure");
				userJournals = await userJournalTable
					//.Where (uj => uj.id == thisUser.id)
					.ToListAsync();

				//Debug output to the console
				Console.WriteLine ("DEBUG - UserJournals");
				foreach (var journal in userJournals) {
					Console.WriteLine (string.Format ("ID: {0}\nName: {1}", journal.id, journal.statName));
				}

				Console.WriteLine ("GetUserJournal method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during GetUserJournals(), retrying connection to Azure");
				GetUserJournals (thisUser);
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.GetUserJournals(): " + e);
			}
		}//end GetUserJournals method

		//Create UserJoural record
		public async static void CreateUserJournal (UserAccount thisUser, UserJournal journal)
		{
			try {
				Console.WriteLine ("CreateUserJournal method called");
				//Set UserJournal table object
				userJournalTable = azureClient.GetTable<UserJournal> ();

				//Insert new record
				Console.WriteLine("Inserting journal record into Azure");
				await userJournalTable.InsertAsync (journal);

				//Call GetUserAccount to fetch the Id for the newly created UserAccount record
				GetUserJournals (thisUser);

				Console.WriteLine ("CreateUserJournal method successful");
			} catch (System.Net.WebException e) {
				Console.WriteLine ("NameResolution detected during CreateUserJournal(), retrying connection to Azure");
				CreateUserJournal (thisUser, journal);
			} catch (Exception e) {
				Console.WriteLine ("ERROR Azure.CreateUserJournal(): " + e);
			}
		}//end CreateUserJournal method
	}
}
