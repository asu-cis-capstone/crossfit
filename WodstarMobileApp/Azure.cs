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
			Console.WriteLine ("InitializeAzure method called");
			//connect to Azure
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66");
			Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);
			CurrentPlatform.Init ();
			//DB connect test
			Console.WriteLine ("Azure initialization successful");
		}//end initializeAzure method

		//Query UserAccount table for the authenticated user
		public async static void GetUserAccount (UserAccount thisUser)
		{
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount> ();

			//Query the UserAccount table for the logged in user
			List<UserAccount> users = await userAccountTable
				.Where (u => u.username == thisUser.username)
				.Where (u => u.accountType == thisUser.accountType)
				.ToListAsync ();

			//Create the record in UserAccount table if no records are found
			if (users.Count == 0) {
				CreateUserAccount (thisUser);
			//Otherwise populate thisUser object with the fetched details
			} else {
				thisUser.id = users [0].id;
				thisUser.gender = users [0].gender;
				thisUser.age = users [0].age;
			}
			Console.WriteLine ("Azure read successful");
		}//end UserAccount method

		//Create UserAccount record, called automatically by GetUserAccount when no account exists
		public async static void CreateUserAccount (UserAccount thisUser)
		{
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount> ();

			//Insert new record
			await userAccountTable.InsertAsync (thisUser);

			//Call GetUserAccount to fetch the Id for the newly created UserAccount record
			GetUserAccount (thisUser);
			Console.WriteLine ("User account creation succesful");
		}//end CreateUserAccount method

		//Query Workout table for all workouts
		public async static void GetWorkouts ()
		{
			//Set Workouts table object
			workoutTable = azureClient.GetTable<Workout> ();

			//Fetch all workouts into a List
			workouts = await workoutTable.ToListAsync ();

			//Debug output to the console
			Console.WriteLine ("DEBUG - GetWorkouts");
			foreach (var workout in workouts) {				
				if (workouts != null) {
					Console.WriteLine (string.Format ("ID: {0}\nName: {1}\nType: {2}", workout.id, workout.workoutName, workout.workoutType));
					//Create new Workout object off of data
					Workout workoutDom = new Workout (workout.workoutName, workout.workoutType, workout.segments);
					//Add to correct data lists in workoutUtil
					if (workout.workoutType == WorkoutUtil.benchmarkType) {
						WorkoutUtil.benchmarkIds.Add (workout.workoutName, workout.id);
						WorkoutUtil.benchmarkWods.Add (workout.id, workoutDom);					
					} else if (workout.workoutType == WorkoutUtil.heroType) {
						WorkoutUtil.heroIds.Add (workout.workoutName, workout.id);
						WorkoutUtil.heroWods.Add (workout.id, workoutDom);	
					} else if (workout.workoutType == WorkoutUtil.camilleType) {
						WorkoutUtil.camilleIds.Add (workout.workoutName, workout.id);
						WorkoutUtil.camilleWods.Add (workout.id, workoutDom);	
					} else if (workout.workoutType == WorkoutUtil.wodstarType) {
						WorkoutUtil.wodstarIds.Add (workout.workoutName, workout.id);
						WorkoutUtil.wodstarWods.Add (workout.id, workoutDom);	
					}
				}
			}
		}//end GetWorkouts method

		//Query WorkoutSegment table for all workout segments
		public async static void GetWorkoutSegments ()
		{
			//Set WorkoutSegments table object
			workoutSegmentTable = azureClient.GetTable<WorkoutSegment> ();

			//Fetch all workout segments into a List
			workoutSegments = await workoutSegmentTable
				.ToListAsync ();

			//Debug output to the console
			Console.WriteLine ("DEBUG - GetWorkoutSegments");
			if (workoutSegments != null) {
				foreach (var segment in workoutSegments) {
					Console.WriteLine (string.Format ("ID: {0}\nWorkout: {1}\nType: {2}", segment.id, segment.workoutId, segment.segmentType));
				}
			}
		}//end GetWorkoutSegments method

		//Query Movements table for all movements
		public async static void GetMovements ()
		{
			//Set Movements table object
			movementTable = azureClient.GetTable<Movement> ();

			//Fetch all movements into a List
			movements = await movementTable.ToListAsync ();

			//Debug output to the console
			Console.WriteLine ("DEBUG - Movements");
			foreach (var movement in movements) {
				Console.WriteLine (string.Format ("ID: {0}\nName: {1}", movement.id, movement.name));
				MovementLinks.allMovements = new List<Movement> ();
				Movement thisMovement = new Movement (movement.classification, movement.name, movement.equipment, movement.type,
					                        movement.blackDiamondDescription, movement.blueSquareDescription, movement.greenCircleDescription, movement.rxVideoUrl,
					                        movement.rxImageUrl, movement.blackDiamondVideoUrl, movement.blackDiamondImageUrl, movement.blueSquareVideoUrl, movement.blueSquareImageUrl,
					                        movement.greenCircleVideoUrl, movement.greenCircleImageUrl);
				MovementLinks.allMovements.Add(thisMovement);
			}
		}//end GetMovements method

		//Query UserJournal table for this user's journal entries
		public async static void GetUserJournals (UserAccount thisUser)
		{
			//Set UserJournal table object
			userJournalTable = azureClient.GetTable<UserJournal> ();

			//Fetch all of this user's journals into a List
			userJournals = await userJournalTable.Where (uj => uj.userAccountId == thisUser.id).ToListAsync ();

			//Debug output to the console
			Console.WriteLine ("DEBUG - UserJournals");
			foreach (var journal in userJournals) {
				Console.WriteLine (string.Format ("ID: {0}\nName: {1}", journal.id, journal.statName));
			}
		}//end GetUserJournals method

		//Create UserJoural record
		public async static void CreateUserJournal (UserAccount thisUser, UserJournal journal)
		{
			//Set UserJournal table object
			userJournalTable = azureClient.GetTable<UserJournal> ();

			//Insert new record
			await userJournalTable.InsertAsync (journal);

			//Call GetUserAccount to fetch the Id for the newly created UserAccount record
			GetUserJournals (thisUser);
		}//end CreateUserJournal method
	}
}

