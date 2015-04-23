using System;
using System.Threading.Tasks;
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
		private static IMobileServiceTableQuery<Workout> workoutTable;
		public static List<Workout> workouts;
		private static IMobileServiceTableQuery<WorkoutSegment> workoutSegmentTable;
		public static List<WorkoutSegment> workoutSegments;
		private static IMobileServiceTableQuery<Movement> movementTable;
		public static List<Movement> movements;
		private static IMobileServiceTableQuery<UserJournal> userJournalTable;
		public static List<UserJournal> userJournals;
		private static IMobileServiceTable<UserJournal> userJournalTableWrite;
		private static IMobileServiceTableQuery<UserSubscription> userSubscriptionTable;
		public static List<UserSubscription> userSubscriptions;
		private static IMobileServiceTable<UserSubscription> userSubscriptionTableWrite;


		//Initialize connection to Azure Mobile Service
		public static void InitializeAzure ()
		{
			try {
				//Debug output
				Console.WriteLine ("InitializeAzure method called");

				//connect to Azure
				azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66");
				Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);
				CurrentPlatform.Init ();

				//Debug output
				Console.WriteLine ("Azure initialization successful");
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.InitializeAzure(): " + e);
			}
		}//end initializeAzure method

		//Query UserAccount table for the authenticated user
		public async static void GetUserAccount (UserAccount thisUser)
		{
			try {
				//Debug output
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

				//Debug output
				Console.WriteLine ("Azure GetUserAccount method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetUserAccount(), retrying connection to Azure");
				GetUserAccount (thisUser);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetUserAccount(): " + e);
			}
		}//end GetUserAccount method

		//Create UserAccount record, called automatically by GetUserAccount when no account exists
		public async static void CreateUserAccount (UserAccount thisUser)
		{
			try {
				//Debug output
				Console.WriteLine ("CreateUserAccount method called");

				//Set UserAccount table object
				userAccountTable = azureClient.GetTable<UserAccount> ();

				//Insert new record
				Console.WriteLine ("Inserting new user into Azure database");
				await userAccountTable.InsertAsync (thisUser);

				//Call GetUserAccount to fetch the Id for the newly created UserAccount record
				GetUserAccount (thisUser);

				//Debug output
				Console.WriteLine ("CreateUserAccount method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during CreateUserAccount(), retrying connection to Azure");
				CreateUserAccount (thisUser);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.CreateUserAccount(): " + e);
			}
		}//end CreateUserAccount method

		//Query Workout table for all workouts
		public async static void GetWorkouts ()
		{
			//Debug output
			Console.WriteLine ("GetWorkouts method called");

			try {
				//Set Workouts table object
				workoutTable = azureClient.GetTable<Workout> ().Take(1000);

				//Fetch all workouts into a List
				Console.WriteLine("Getting workouts from Azure");
				workouts = await workoutTable.LoadAllAsync();

				//Loop through the workout list
				foreach (var workout in workouts) {
					//Debug output
					Console.WriteLine (string.Format ("Workout: {0}\nName: {1}\nType: {2}", workout.id, workout.workoutName, workout.workoutType));

					//Create new Workout object from the data
					Workout workoutDom = new Workout (workout.workoutName, workout.workoutType);
					workoutDom.id = workout.id;

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

				//Debug output
				Console.WriteLine ("GetWorkouts method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetWorkouts(), retrying connection to Azure");
				GetWorkouts ();
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetWorkouts(): " + e);
			}
		}//end GetWorkouts method

		//Query WorkoutSegment table for all workout segments
		public async static void GetWorkoutSegments ()
		{
			try {
				//Debug output
				Console.WriteLine ("GetWorkoutSegments method called");

				//Set WorkoutSegments table object
				workoutSegmentTable = azureClient.GetTable<WorkoutSegment> ().Take(1000);

				//Fetch all workout segments into a List
				Console.WriteLine("Fetching workout segments from Azure");
				workoutSegments = await workoutSegmentTable.LoadAllAsync();

				if (workoutSegments != null) {
					Console.WriteLine("WorkoutSegments table not null");
					WorkoutUtil.allSegments = new List<WorkoutSegment>();
					foreach (var segment in workoutSegments) {						
						WorkoutSegment s = new WorkoutSegment(segment.segmentType, segment.workoutId, segment.segmentHeader, segment.segmentDescription,
							segment.repetitions, segment.movementDescriptions, segment.segmentMovements);	
						s.id = segment.id; 
						WorkoutUtil.allSegments.Add(s);
						Console.WriteLine("Workout Segment Added: " + s.id);
					}
				}

				//Debug output
				Console.WriteLine ("GetWorkoutSegments method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetWorkoutSegments(), retrying connection to Azure");
				GetWorkoutSegments ();
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetWorkoutSegments(): " + e);
			}
		}//end GetWorkoutSegments method

		//Query Movements table for all movements
		public async static void GetMovements ()
		{
			try {
				//Debug output
				Console.WriteLine ("GetMovements method called");

				//Set Movements table object
				movementTable = azureClient.GetTable<Movement> ().Take(1000);
				MovementLinks.allMovements = new List<Movement>();
				MovementLinks.movementDictionary = new Dictionary<string, Movement>();

				//Fetch all movements into a List
				Console.WriteLine("Fetching movement data from Azure");
				movements = await movementTable.LoadAllAsync();
				Console.WriteLine(movements.ToString());

				//Debug output to the console
				Console.WriteLine ("DEBUG - Movements");

				//Loop through the movements list
				for(int i = 0; i <movements.Count; i++) {
					Console.WriteLine (string.Format ("Movmement # " + i + ": ID: {0}\nName: {1}", movements[i].id, movements[i].name));
					Movement m = new Movement();
					m.name = movements[i].name;
					m.id = movements[i].id.Trim();
					m.rxImageUrl = movements[i].rxImageUrl;
					m.rxVideoUrl = movements[i].rxVideoUrl;
					m.blackDiamondDescription = movements[i].blackDiamondDescription;
					m.blackDiamondImageUrl = movements[i].blackDiamondImageUrl;
					m.blackDiamondVideoUrl = movements[i].blackDiamondVideoUrl;
					m.blueSquareDescription = movements[i].blueSquareDescription;
					m.blueSquareImageUrl = movements[i].blueSquareImageUrl;
					m.blueSquareVideoUrl = movements[i].blueSquareVideoUrl;
					m.greenCircleDescription = movements[i].greenCircleDescription;
					m.greenCircleImageUrl = movements[i].greenCircleImageUrl;
					m.greenCircleVideoUrl = movements[i].greenCircleVideoUrl;
					m.classification = movements[i].classification;
					m.equipment = movements[i].equipment;
					m.type = movements[i].type;
					MovementLinks.allMovements.Add(m);
					MovementLinks.movementDictionary.Add(m.id, m);
				}

				//Debug output
				Console.WriteLine ("GetMovements method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetMovements(), retrying connection to Azure");
				GetMovements ();
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetMovements(): " + e);
			}
		}//end GetMovements method

		//Query UserJournal table for this user's journal entries
		public async static void GetUserJournals (UserAccount thisUser)
		{
			try {
				//Debug output
				Console.WriteLine ("GetUserJournals method called");

				//Set UserJournal table object
				userJournalTable = azureClient.GetTable<UserJournal> ().Take(1000);

				//Fetch all of this user's journals into a List
				Console.WriteLine("Fetching user's journals from Azure");
				userJournals = await userJournalTable
					.Where (uj => uj.userAccountId == thisUser.id)
					.LoadAllAsync();

				//Debug output to the console
				Console.WriteLine ("DEBUG - UserJournals");
				JournalUtil.wodJournalData = new List<List<UserJournal>>();
				JournalUtil.prJournalData = new List<List<UserJournal>>();
				//Loop through the journals list
				if(userJournals!=null) {
					foreach (var journal in userJournals) {
						UserJournal j = new UserJournal();
						j.entryType = journal.entryType;
						j.id = journal.id;
						j.userAccountId = journal.userAccountId;
						j.statType = journal.statType;
						j.statResult = journal.statResult;
						j.statId = journal.statId;
						j.statDateTime = journal.statDateTime;
						j.statName = journal.statName;
						Console.WriteLine (string.Format ("ID: {0}\nName: {1}", journal.id, journal.statName));
						if(WorkoutUtil.benchmarkWods.ContainsKey(j.statId) || WorkoutUtil.heroWods.ContainsKey(j.statId) ||
								WorkoutUtil.wodstarWods.ContainsKey(j.statId) || WorkoutUtil.camilleWods.ContainsKey(j.statId)) {
							JournalUtil.wodJournalData.Add(j);
						} else if(MovementLinks.movementDictionary.ContainsKey(j.statId)){
							JournalUtil.prJournalData.Add(j);
						} else {
							Console.WriteLine("Not found with name: " + j.statName);
						}
					}
				}
				//Debug output
				Console.WriteLine ("GetUserJournal method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetUserJournals(), retrying connection to Azure");
				GetUserJournals (thisUser);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetUserJournals(): " + e);
			}
		}//end GetUserJournals method

		//Create UserJoural record
		public async static void CreateUserJournal (UserAccount thisUser, UserJournal journal)
		{
			try {
				//Debug output
				Console.WriteLine ("CreateUserJournal method called");

				//Set UserJournal table object
				userJournalTable = azureClient.GetTable<UserJournal> ().Take(1000);

				//Insert new journal record
				Console.WriteLine("Inserting journal record into Azure");
				await userJournalTableWrite.InsertAsync (journal);

				//Call GetUserAccount to refresh the user's journals
				GetUserJournals (thisUser);

				//Debug output
				Console.WriteLine ("CreateUserJournal method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during CreateUserJournal(), retrying connection to Azure");
				CreateUserJournal (thisUser, journal);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.CreateUserJournal(): " + e);
			}
		}//end CreateUserJournal method

		//Query UserSubscription table for this user's subscriptions
		public async static void GetUserSubscriptions (UserAccount thisUser)
		{
			try {
				//Debug output
				Console.WriteLine ("GetUserSubscriptions method called");

				//Set UserSubscriptions table object
				userSubscriptionTable = azureClient.GetTable<UserSubscription> ().Take(1000);

				//Fetch all of this user's subscriptions into a List
				Console.WriteLine("Fetching user's subscriptions from Azure");
				userSubscriptions = await userSubscriptionTable
					.Where (us => us.userAccountId == thisUser.id)
					.LoadAllAsync();

				//Debug output to the console
				Console.WriteLine ("DEBUG - UserSubscriptions");

				//Loop through the subscriptions list
				if (userSubscriptions != null) {
					foreach (var subscription in userSubscriptions) {
						Console.WriteLine (string.Format ("ID: {0}\nName: {1}", subscription.id, subscription.subName));
					}
				}

				//Debug output
				Console.WriteLine ("GetUserSubscriptions method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during GetUserSubscriptions(), retrying connection to Azure");
				GetUserSubscriptions (thisUser);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.GetUserSubscriptions(): " + e);
			}
		}//end GetUserSubscriptions method

		//Create UserSubscription record
		public async static void CreateUserSubscription (UserAccount thisUser, UserSubscription subscription)
		{
			try {
				//Debug output
				Console.WriteLine ("CreateUserSubscription method called");

				//Set UserSubscription table object
				userSubscriptionTable = azureClient.GetTable<UserSubscription> ().Take(1000);

				//Insert new subscription record
				Console.WriteLine("Inserting subscription record into Azure");
				await userSubscriptionTableWrite.InsertAsync (subscription);

				//Call GetUserSubscriptions to refresh the user's journals
				GetUserSubscriptions (thisUser);

				//Debug output
				Console.WriteLine ("CreateUserSubscription method successful");
			} catch (System.Net.WebException) {
				//Handle NameResolution error caused by lack of or poor Internet connectivity
				Console.WriteLine ("NameResolution error detected during CreateUserSubscription(), retrying connection to Azure");
				CreateUserSubscription (thisUser, subscription);
			} catch (Exception e) {
				//Unhandled exception output
				Console.WriteLine ("ERROR Azure.CreateUserSubscription(): " + e);
			}
		}//end CreateUserSubscription method

		//Fetches data from Azure in pages to get more than the first 50
		public async static Task<List<T>> LoadAllAsync<T>(this IMobileServiceTableQuery<T> table, int bufferSize = 1000)
		{
			var query = table.IncludeTotalCount();
			var results = await query.ToEnumerableAsync();
			long count = ((ITotalCountProvider)results).TotalCount;
			if (results != null && count > 0)
			{
				var updates = new List<T>();
				while (updates.Count < count)
				{

					var next = await query.Skip(updates.Count).Take(bufferSize).ToListAsync();
					updates.AddRange(next);
				}
				return updates;
			}

			return null;
		}//end LoadAllAsync method
	}
}
