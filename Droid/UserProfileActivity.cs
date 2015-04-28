
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using Xamarin.Facebook;
using Xamarin.Facebook.Widget;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "UserProfileActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class UserProfileActivity : Activity
	{
		private TextView userNameTextView;
		private TextView userInfoTextView;
		private TableLayout userDataTable;
		private Button wodDataButton;
		private Button prDataButton;
		private bool wodVisible;
		private FrameLayout headerLayout;
		private ProfilePictureView profilePicture;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Journal);
		
			//Get instances of variable layout components		
			userDataTable = FindViewById<TableLayout> (Resource.Id.userDataTable);
			wodDataButton = FindViewById<Button> (Resource.Id.wodButton);
			prDataButton = FindViewById<Button> (Resource.Id.prButton);
			headerLayout = FindViewById<FrameLayout> (Resource.Id.headerLayout);

			//TODO: check and see if user has uploaded their own, then set background accordingly. 
			headerLayout.SetBackgroundResource (Resource.Drawable.fillerDefaultCoverPhoto);
			LinearLayout profileLayout = new LinearLayout (this);
			profileLayout.Orientation = Orientation.Vertical;
			userNameTextView = new TextView (this);
			userInfoTextView = new TextView (this);
			userNameTextView.Text = Util.thisUser.firstName + " " + Util.thisUser.lastName;
			userNameTextView.SetTextColor (Android.Graphics.Color.White);
			userInfoTextView.SetTextColor (Android.Graphics.Color.White);
			userInfoTextView.Text= "\nGender: " + Util.thisUser.gender;
			userNameTextView.Gravity = GravityFlags.CenterHorizontal;
			userInfoTextView.Gravity = GravityFlags.CenterHorizontal;
			profilePicture = new ProfilePictureView (this);
			profilePicture.ProfileId = Util.thisUser.id;


			profileLayout.AddView (profilePicture);
			profileLayout.AddView (userNameTextView);
			profileLayout.AddView (userInfoTextView);
			headerLayout.AddView (profileLayout);

			wodDataButton.Click += (sender, e) => {
				createWodTable();
			};
			prDataButton.Click += createPrTable;


			//TODO: Dynamically retrieve user picture and set.

			//Initialize views to Wods
			createWodTable();

			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var hamburgerButton = FindViewById (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};

			var titleButton = FindViewById (Resource.Id.titleTextView);
			var homeButton = FindViewById (Resource.Id.homeTextView);
			var profileButton = FindViewById (Resource.Id.profileTextView);
			var wodLibraryButton = FindViewById (Resource.Id.wodLibraryTextView);
			var movementLibraryButton = FindViewById (Resource.Id.movementLibraryTextView);
			var logoutButton = FindViewById (Resource.Id.logoutTextView);

			titleButton.Click += goToHomeScreen;
			homeButton.Click += goToHomeScreen;
			profileButton.Click += goToUserProfile;
			wodLibraryButton.Click += goToWodLibrary;
			movementLibraryButton.Click += goToMovementLibrary;
			logoutButton.Click += goToLogin;
		}

		void createWodTable() 
		{
			if (!wodVisible) {
				wodVisible = true;
				//TODO: Sort Wod Dictionaries
				clearTable ();
				foreach(KeyValuePair<string, Workout> benchmarkWod in WorkoutUtil.benchmarkWods) {
					int baseInt=0;
					foreach(UserJournal j in JournalUtil.wodJournalData) {
						if(j.statId==(benchmarkWod.Value.id)) {
							Console.Out.WriteLine ("Journal entry matching benchmark wod");
							if(j.entryType == JournalUtil.amrapType) {
								Console.Out.WriteLine ("Journal entry is amrap");
								if(Int32.Parse(j.statResult)> baseInt) {
									baseInt = Int32.Parse(j.statResult);
								}
							}
						}
					}

					TableRow dataRow = new TableRow (this);
					dataRow.SetPadding (0, 30, 0, 30);
					TextView workoutName = new TextView (this);
					workoutName.SetPadding (20, 0, 0, 0);
					workoutName.SetTextSize (Android.Util.ComplexUnitType.Sp, 20);

					workoutName.Gravity = GravityFlags.Left;
					workoutName.Text = benchmarkWod.Value.workoutName;
					dataRow.AddView (workoutName);

					if(baseInt!=0) {
						TextView workoutPr = new TextView (this);
						workoutPr.Gravity = GravityFlags.Right;
						workoutPr.Text = baseInt.ToString ();
						workoutPr.SetTextColor (Android.Graphics.Color.White);
						dataRow.AddView (workoutPr);
					} else {
						Button logButton = new Button (this);
						logButton.Text = "Log";
						logButton.Gravity = GravityFlags.Right;
						logButton.SetBackgroundColor (Android.Graphics.Color.Transparent);
						logButton.SetTextColor (Android.Graphics.Color.White);
						dataRow.AddView (logButton);
						//TODO: Add logging functionality
					}

					userDataTable.AddView (dataRow);
				}
			}
			//User WOD data entry successful

		}

		void createPrTable(object sender, EventArgs e) {
			if (wodVisible) {
				wodVisible = false;
				clearTable ();
				//List<List<int>> prData = Util.thisUser.journal.prStats;
			}
		}

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
			Console.WriteLine ("User WOD data entry successful");
		}

		void clearTable() {

		}

		//NAVIGATION METHODS
		void goToUserProfile(object sender, EventArgs e) {
			//Start a new Activity for the UserProfile layout
			if (this.LocalClassName != "wodstarmobileapp.droid.UserProfileActivity") {
				StartActivity (typeof(UserProfileActivity));
			}
		}

		void goToHomeScreen(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.StartScreenActivity") {
				StartActivity (typeof(StartScreenActivity));
			}
		}

		void goToWodLibrary(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.WorkoutLibraryActivity") {
				StartActivity (typeof(WorkoutLibraryActivity));
			}
		}

		void goToLogin(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.MainActivity") {
				StartActivity (typeof(MainActivity));
			}
		}

		void goToMovementLibrary(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.MovementLibraryActivity") {
				Console.WriteLine ("Local class name = " + this.LocalClassName.ToString ());
				StartActivity (typeof(MovementLibraryActivity));
			}
		}
		//END NAVIGATION METHODS
	}
}

