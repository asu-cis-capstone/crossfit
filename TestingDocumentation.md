# Testing Documentation
Because Xamarin requires that any automated testing be done through its "Test Cloud", we have had to implement testing directly into the code. The "Test Cloud" cost upwards of $12,000/year and is not a tool within our budget. 

###Database Connect
Class: WodstarMobileApp.Azure.cs (line 32)<br/>
Scope: <br/>
Code: <br/>
	public static void InitializeAzure ()
			{
				Console.WriteLine ("InitializeAzure method called");
				//connect to Azure
				azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", 				"aLMiHItrYdPiUdpjhotOQZAHKLDqVd66");
				Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);
				CurrentPlatform.Init ();
				//DB connect test
				Console.WriteLine ("Azure initialization successful");
			}//end initializeAzure method


###Database Read
Class: WodstarMobileApp.Azure.cs (line 56) <br/>
Scope: <br/>
Code: <br/>

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
				} else 
					thisUser.id = users [0].id;
					thisUser.gender = users [0].gender;
					thisUser.age = users [0].age;
				}
				//DB read test
				Console.WriteLine ("Azure read successful");
			}//end UserAccount method


###User Account Creation 
Class: WodstarMobileApp.Azure.cs (line 70) <br/>
Scope: <br/>
Code: <br/>
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

###Facebook Login
Class: WodstarMobileApp.Droid.MainActivity.cs (line 43) <br/>
Scope: <br/>
Code: <br/>
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



###Facebook Logout
Class: <br/>
Scope: <br/>
Code:

###YouTube Connect
Class: WodstarMobileApp.Droid.MovementLibraryActivity.cs (line 81)<br/>
Scope: <br/>
Code: <br/>
protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()<br/>
		{<br/>
<br/>
			if (!firstPlayer) {<br/>
				return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);<br/>
			} else if (!secondPlayer) {<br/>
				return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer2);<br/>
			} else if (!thirdPlayer) {<br/>
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer3);<br/>
			} else if (!fourthPlayer) {<br/>
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer4);<br/>
			} else if (!fifthPlayer) {<br/>
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer5);<br/>
			}<br/>
			<b>Console.WriteLine ("YouTube connect successful");</b><br/>
			return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);<br/>
		}<br/>


###YouTube Load
Class: WodstarMobileApp.Droid.MovementLibraryActivity.cs (line 89) <br/>
Code: <br/>
public override void OnInitializationSuccess (IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored) <br/>
		{<br/>
			if (!wasRestored) {<br/>
				loadVideos(player);<br/>
				Console.WriteLine ("YouTube load successful");<br/>
			} <br/>
		}<br/>

###WOD Page Search
Class: <br/>
Scope: <br/>
Code:

###WOD Data Added
Class: WodstarMobileApp.Azure.cs (<br/>
Scope: <br/>
Code:





