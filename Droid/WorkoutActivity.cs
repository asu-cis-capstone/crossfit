
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
using WodstarMobileApp;
using Google.YouTube.Player;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "WorkoutActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class WorkoutActivity : YouTubeFailureRecoveryActivity
	{
		public Workout thisWorkout;
		private List<String> movementUrls = new List<String> ();
		private String workoutId=null;
		private ImageView wodImage;
		String segmentMovementDescriptions = null;

		//Sample workouts hardcoded for demo purposes
		private static WorkoutSegment amanda1 = new WorkoutSegment (WorkoutUtil.forTime, "Description", "3 Rounds for time of 9-7-5 reps of:", 
			1, new String[]{null}, MovementLinks.ringMuscleUpMovement, MovementLinks.squatSnatchMovement);
		private Workout amandaWorkout = new Workout ("Amanda", amanda1);
		private static WorkoutSegment jackieSegment = new WorkoutSegment (WorkoutUtil.forTime, "Description", 
			"Complete the following for time:", 1, new String[]{"1,000 meter Row", "50 (45/35)", "30"}, MovementLinks.rowingMovement, MovementLinks.thrusterMovement, 
           MovementLinks.pullUpMovement);
		private Workout jackieWorkout = new Workout ("Jackie", jackieSegment);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			//Get all the changeable sections of the layout.
			TextView wodHeaderText = FindViewById<TextView> (Resource.Id.wodHeaderText);
			wodImage = FindViewById<ImageView> (Resource.Id.wodstarImage);
			TableLayout workoutDetailsLayout = FindViewById<TableLayout> (Resource.Id.workoutDetailsLayout);
			YouTubePlayerFragment movementVideos = (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.movementVideos);

			//Captures data from starting activity, loads the proper data to the page.
			workoutId = Intent.GetStringExtra ("workoutId");
			setThisWorkout ();
			wodHeaderText.Text = thisWorkout.workoutName;

			//Dynamically load workout content
			for(int i=0;i <thisWorkout.segments.Length; i++) {
				TableRow segmentHeader = new TableRow (this);
				TextView headerText = new TextView (this);
				headerText.Text =thisWorkout.segments [i].segmentHeader;
				segmentHeader.AddView (headerText);

				TableRow segmentDescription = new TableRow (this);
				TextView descriptionText = new TextView (this);
				descriptionText.Text = getRxSegmentDescription (thisWorkout.segments [i]);
				segmentDescription.AddView (descriptionText);

				//Initial call to load RX Video Links
				loadRxVideos (thisWorkout.segments[i]);

				workoutDetailsLayout.AddView (segmentHeader);
				workoutDetailsLayout.AddView (segmentDescription);
			}

			//Has to be at the end to add to video cue.
			movementVideos.Initialize (DeveloperKey.key, this);

			//MENU METHODS
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
			//END MENU METHODS

		} //End onCreate

		private String getRxSegmentDescription(WorkoutSegment segment) {
			String s = null;
			for(int j = 0; j< segment.segmentMovements.Length; j++) {
				s = s + "\n" + segment.segmentDescription [j] + " " + segment.segmentMovements [j].rxName;
			}
			return s;
		}

		void loadRxVideos(WorkoutSegment segment) {
			foreach(Movement m in segment.segmentMovements) {
				if (m.rxLink != null) {
					movementUrls.Add (m.rxLink);
				}
			}
		}

		void setThisWorkout() {
			switch (Int64.Parse(workoutId)) {
			case 1: //Amanda
				thisWorkout = amandaWorkout;
				wodImage.SetImageResource (Resource.Drawable.amanda);
				break;
			case 2: //Jackie
				thisWorkout = jackieWorkout;
				wodImage.SetImageResource (Resource.Drawable.jackie);
				break;
			default: 
				//TODO: Add error handling
				break;
			}
		}

		//YOUTUBE METHODS
		protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()
		{
			return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.movementVideos);
		}
		private void loadVideos(IYouTubePlayer player) {
			player.CueVideos (movementUrls);
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

