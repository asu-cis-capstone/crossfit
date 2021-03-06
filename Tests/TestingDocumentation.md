# Testing Documentation
We are currenlty using Xamarin Studio for the cross platform development of this mobile application. Unfortunately, Xamarin requires that any automated testing be done through its "Test Cloud". The "Test Cloud" cost upwards of $12,000/year and is not a tool within our project budget. In order to overcome this we have implemented basic tests through the the console.

###Azure Connect
Class: *WodstarMobileApp.Azure.cs* (line 32)<br/>
Purpose: To test that there was a successful connection to Azure<br/>
Platform: Cross <br/>

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

###Azure Get User
Class: *WodstarMobileApp.Azure.cs* (line 56) <br/>
Purpose: To test if the application is properly reading from Azure. <br/>
Platform: Cross <br/>


	public async static void GetUserAccount (UserAccount thisUser)
		{
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
			}
			Console.WriteLine ("Azure GetUserAccount method successful");
		}//end GetUserAccount method


###Azure Create User Account
Class: *WodstarMobileApp.Azure.cs* (line 70) <br/>
Purpose: To test that the user can create a new account independent from social login functionality <br/>
Platform: Cross <br/>


	public async static void CreateUserAccount (UserAccount thisUser)
		{
			Console.WriteLine ("CreateUserAccount method called");
			//Set UserAccount table object
			userAccountTable = azureClient.GetTable<UserAccount> ();

			//Insert new record
			Console.WriteLine ("Inserting new user into Azure database");
			await userAccountTable.InsertAsync (thisUser);

			//Call GetUserAccount to fetch the Id for the newly created UserAccount record
			GetUserAccount (thisUser);
			Console.WriteLine ("CreateUserAccount method successful");
		}//end CreateUserAccount method
			
			
###Azure Get Workouts
Class: *WodstarMobileApp.Azure.cs* (line 118) <br/>
Purpose: To test that the workouts were successfully pulled from Azure <br/>
Platform: Cross <br/>

public async static void GetWorkouts ()
		{
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
		}//end GetWorkouts method

###Azure Get Movements
Class: *WodstarMobileApp.Azure.cs* (line 136) <br/>
Purpose: To test that the movements were successfully pulled from Azure <br/>
Platform: Cross <br/>

	public async static void GetMovements ()
		{
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
		}//end GetMovements method

###Facebook Login
Class: *WodstarMobileApp.Droid.MainActivity.cs* (line 43) <br/>
Purpose: To test if the Facebook login functionality is properly working <br/>
Platform: Android <br/>


	protected override void OnCreate (Bundle bundle)
			{
				base.OnCreate (bundle);
				SetContentView (Resource.Layout.Login);
	
				//Connect to Azure
				try {
					Azure.InitializeAzure ();
				} catch( Exception e) {
					Console.WriteLine(e);
				}
	
				//If Facebook session is already open from a previous login, request user info
				if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {
					//Get user info from Facebook
					Request.ExecuteMeRequestAsync (Session.ActiveSession, this);
					//FB login test
					Console.WriteLine ("Facebook login successful");
				} else {
					//Enable the skip button to go directly into the Main layout
					var skipButton = FindViewById<Button> (Resource.Id.startScreenButton);
					skipButton.Click += goToStart;
				}

###YouTube Connect
Class: *WodstarMobileApp.Droid.MovementLibraryActivity.cs (line 81)*<br/>
Purpose: To test that the applicaiton successfully connected to YouTube <br/>
Platform: Android </br>


		public override void OnInitializationSuccess (IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored)
			{
				if (!wasRestored) {
					loadVideos(player);
					//YouTube load test
					Console.WriteLine ("YouTube load successful");
				} 
			}


###YouTube Load
Class: *WodstarMobileApp.Droid.MovementLibraryActivity.cs* (line 89) <br/>
Purpose: To test that the YouTube videos sucessfully loaded in the workout library <br/>
Platform: Android <br/>

	private void loadVideos(IYouTubePlayer player) 
		{
			if (!firstPlayer) {
				player.CueVideo (MovementLinks.MovementUrls [startIndex], 50);
				firstPlayer = true;
			} else if (!secondPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+1], 50);
				secondPlayer=true;
			} else if (!thirdPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+2], 50);
				thirdPlayer=true;
			} else if (!fourthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+3], 50);
				fourthPlayer=true;
			} else {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+4], 50);
				fifthPlayer=true;
			}
			Console.WriteLine ("YouTube load successful");
		}


###WOD Page Search
Class: *WodstarMobileApp.Droid.HeroWodsActivity.cs* (line 173)
Purpose: To test if the search function in the WOD library is properly working<br/>
Platform: Android <br/>

	void searchItemSelected(object sender, AdapterView.ItemClickEventArgs e) {
				String workoutSelected = autocompleteHero.Text;
				if(WorkoutUtil.benchmarkIds.ContainsKey(workoutSelected)) {
					var intent = new Intent(this, typeof(WorkoutActivity));
					intent.PutExtra("workoutName", workoutSelected);
					intent.PutExtra("workoutId", WorkoutUtil.benchmarkIds[workoutSelected]);
					StartActivity(intent);
				}
				//WOD page search test
				Console.WriteLine ("WOD page search successful");
			}

###User WOD Data Entry
Class: *WodstarMobileApp.Droid.UserProfileActivity* (line 113) <br/>
Purpose: To test if the user can sucessfully add WOD data to their journal <br/>
Platform: Android <br/>

	void addDataToTable(String[][] resultInfo) 
			{
				for(int i = 0; i < resultInfo.Count(); i++) {
					TableRow dataRow = new TableRow (this);
					TextView workoutName = new TextView (this);
					TextView workoutPr = new TextView (this);
					workoutName.Text =resultInfo [i] [0];
					workoutPr.Text = resultInfo [i] [1];
					workoutPr.Gravity = GravityFlags.Right;
					workoutName.Gravity = GravityFlags.Left;
					dataRow.AddView (workoutName);
					dataRow.AddView (workoutPr);
	
					userDataTable.AddView (dataRow);
				}
				//User WOD data entry test
				Console.WriteLine ("User WOD data entry successful");
			}





