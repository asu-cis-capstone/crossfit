# Testing Documentation
Because Xamarin requires that any automated testing be done through its "Test Cloud", we have had to implement testing directly into the code. The "Test Cloud" cost upwards of $12,000/year and is not a tool within our budget. 

###Database Connect
Class: WodstarMobileApp.Azure.cs (line 32)<br/>
Scope: <br/>
Code: <br/>
public static void InitializeAzure ()
		{
			Console.WriteLine ("InitializeAzure method called"); <br/>
			//connect to Azure <br/>
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66"); <br/>
			Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);<br/>
			CurrentPlatform.Init ();<br/>
			<b>//DB connect test<br/>
			Console.WriteLine ("Azure initialization successful");</b><br/>
		}//end initializeAzure method<br/>

###Database Read
Class: WodstarMobileApp.Azure.cs (line 56) <br/>
Scope: <br/>
Code: <br/>
public async static void GetUserAccount (UserAccount thisUser) <br/>
		{<br/>
			//Set UserAccount table object<br/>
			userAccountTable = azureClient.GetTable<UserAccount> ();<br/>
<br/>
			//Query the UserAccount table for the logged in user<br/>
			List<UserAccount> users = await userAccountTable<br/>
				.Where (u => u.username == thisUser.username)<br/>
				.Where (u => u.accountType == thisUser.accountType)<br/>
				.ToListAsync ();<br/>

			//Create the record in UserAccount table if no records are found<br/>
			if (users.Count == 0) {<br/>
				CreateUserAccount (thisUser);<br/>
			//Otherwise populate thisUser object with the fetched details<br/>
			} else {<br/>
				thisUser.id = users [0].id;<br/>
				thisUser.gender = users [0].gender;<br/>
				thisUser.age = users [0].age;<br/>
			}<br/>
			<b>Console.WriteLine ("Azure read successful");</b><br/>
		}//end UserAccount method<br/>


###User Account Creation 
Class: WodstarMobileApp.Azure.cs (line 70) <br/>
Scope: <br/>
Code: <br/>
public async static void CreateUserAccount (UserAccount thisUser)<br/>
		{<br/>
			//Set UserAccount table object<br/>
			userAccountTable = azureClient.GetTable<UserAccount> ();<br/>
<br/>
			//Insert new record<br/>
			await userAccountTable.InsertAsync (thisUser);<br/>
<br/>
			//Call GetUserAccount to fetch the Id for the newly created UserAccount record<br/>
			GetUserAccount (thisUser);<br/>
			<b>Console.WriteLine ("User account creation succesful");</b><br/>
		}//end CreateUserAccount method<br/>

###Facebook Login
Class: WodstarMobileApp.Droid.MainActivity.cs (line 43) <br/>
Scope: <br/>
Code: <br/>
protected override void OnCreate (Bundle bundle) <br/>
		{<br/>
			base.OnCreate (bundle);<br/>
			SetContentView (Resource.Layout.Login);<br/>
<br/>
			//Connect to Azure<br/>
			try {<br/>
				Azure.InitializeAzure ();<br/>
			} catch( Exception e) {<br/>
				Console.WriteLine(e);<br/>
			}<br/>
<br/>
			//If Facebook session is already open from a previous login, request user info<br/>
			if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {<br/>
				//Get user info from Facebook<br/>
				Request.ExecuteMeRequestAsync (Session.ActiveSession, this);<br/>
				//FB login test<br/>
				<b>Console.WriteLine ("Facebook login successful");</b><br/>
			} else {<br/>
				//Enable the skip button to go directly into the Main layout<br/>
				var skipButton = FindViewById<Button> (Resource.Id.startScreenButton);<br/>
				skipButton.Click += goToStart;<br/>
			}<br/>
		}//end OnCreate method<br/>


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





