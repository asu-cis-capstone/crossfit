
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

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "UserProfileActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class UserProfileActivity : Activity
	{
		private TextView userNameTextView;
		private TextView userInfoTextView;
		private ImageView userProfilePicture;
		private TableLayout userDataTable;
		private Button wodDataButton;
		private Button prDataButton;
		private bool wodVisible;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Journal);

			//Get instances of variable layout components
			userNameTextView = FindViewById<TextView> (Resource.Id.userNameTextView);
			userInfoTextView = FindViewById<TextView> (Resource.Id.userInfoTextView);
			userProfilePicture = FindViewById<ImageView> (Resource.Id.profilePictureImageView);
			userDataTable = FindViewById<TableLayout> (Resource.Id.userDataTable);
			wodDataButton = FindViewById<Button> (Resource.Id.wodButton);
			prDataButton = FindViewById<Button> (Resource.Id.prButton);

			wodDataButton.Click += createWodTable ();
			prDataButton.Click += createPrTable ();

			userNameTextView.Text = Util.thisUser.FirstName + " " + Util.thisUser.LastName;
			userInfoTextView .Text= "Age: " + Util.thisUser.Age + "\nGender: " + Util.thisUser.Gender;
			//TODO: Dynamically retrieve user picture and set.

			//Initialize views to Wods
			createWodTable ();

			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var hamburgerButton = FindViewById (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};

			var titleButton = FindViewById (Resource.Id.titleTextView);
			var homeButton = FindViewById (Resource.Id.homeTextView);
			var profileButton = FindViewById (Resource.Id.profileTextView);
			var journalButton = FindViewById (Resource.Id.journalTextView);
			var wodLibraryButton = FindViewById (Resource.Id.wodLibraryTextView);
			var movementLibraryButton = FindViewById (Resource.Id.movementLibraryTextView);
			var logoutButton = FindViewById (Resource.Id.logoutTextView);

			titleButton.Click += goToHomeScreen;
			homeButton.Click += goToHomeScreen;
			profileButton.Click += goToUserProfile;
			journalButton.Click += goToJournal;
			wodLibraryButton.Click += goToWodLibrary;
			movementLibraryButton.Click += goToMovementLibrary;
			logoutButton.Click += goToLogin;
		}

		void createWodTable() {
			if (!wodVisible) {
				wodVisible = true;
				clearTable ();
				List<List<int>> wodData = Util.thisUser.journal.workoutStats;
				//TODO: Sort data into new array by the number of entries then by alphabet if necessary
				//TODO: for each entry, sort for the best value - how? depends on id of workout amrap/time going to be different sorts.
				//TODO: create string[] of workouts name and the value - create maps of id to name in workout util?
				String[][] workoutResultInfo = new String[wodData.Count ()] [1];
				addDataToTable (workoutResultInfo);
			}
		}

		void createPrTable() {
			if (wodVisible) {
				wodVisible = false;
				clearTable ();
				List<List<int>> prData = Util.thisUser.journal.prStats;
			}
		}

		void addDataToTable(String[][] resultInfo) {
			for(int i = 0; i < resultInfo.Count(); i++) {
				TableRow dataRow = new TableRow ();
				TextView workoutName = new TextView (resultInfo [i] [0]);
				TextView workoutPr = new TextView (resultInfo [i] [1]);
				dataRow.AddView (workoutName);
				dataRow.AddView (workoutPr);
				userDataTable.AddView (dataRow);
			}
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

		void goToJournal(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.UserJournal") {
				StartActivity (typeof(UserJournal));
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

