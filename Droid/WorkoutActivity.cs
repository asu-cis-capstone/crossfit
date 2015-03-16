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
using Xamarin.Forms;
using com.refractored.monodroidtoolkit;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "WorkoutActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class WorkoutActivity : YouTubeFailureRecoveryActivity
	{
		public Workout thisWorkout;
		private List<String> movementUrls = new List<String> ();
		private String workoutId="1";
		private YouTubePlayerFragment movementVideos;
		private FrameLayout headerLayout;
		private Android.Widget.Button timerButton;
		private HoloCircularProgressBar progressBar;

		//Sample workouts hardcoded for demo purposes
		private static WorkoutSegment amandaSegment = new WorkoutSegment (WorkoutUtil.forTime, "Description", "3 Rounds for time of 9-7-5 reps of:", 
			1, new String[]{null, null}, new Movement[]{MovementLinks.ringMuscleUpMovement, MovementLinks.squatSnatchMovement});
		private static WorkoutSegment jackieSegment = new WorkoutSegment (WorkoutUtil.forTime, "Description", 
			"Complete the following for time:", 1, new String[]{"1,000 meters ", "50 (45/35)", "30"}, new Movement[] {MovementLinks.rowingMovement, MovementLinks.thrusterMovement, 
				MovementLinks.pullUpMovement});

		private Workout jackieWorkout = new Workout ("Jackie", jackieSegment);
		private Workout amandaWorkout = new Workout ("Amanda", amandaSegment);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			//Get all the changeable sections of the layout.
			TableLayout workoutDetailsLayout = FindViewById<TableLayout> (Resource.Id.workoutDetailsLayout);
			movementVideos = (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.movementVideos);
			var circularProgressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);
			circularProgressBar.Indeterminate = true;
			headerLayout = FindViewById<FrameLayout> (Resource.Id.headerLayout);
			timerButton = FindViewById<Android.Widget.Button> (Resource.Id.timerButton);
			progressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);

			//Captures data from starting activity, loads the proper data to the page.
			workoutId = Intent.GetStringExtra ("workoutId");
			setThisWorkout ();

			//Dynamically load workout content
			for(int i=0;i <thisWorkout.segments.Length; i++) {
				TableRow segmentHeader = new TableRow (this);
				TextView headerText = new TextView (this);
				headerText.Text =thisWorkout.segments [i].segmentHeader;
				headerText.SetTextAppearance (this, global::Android.Resource.Style.TextAppearanceLarge);
				segmentHeader.AddView (headerText);

				TableRow segmentDescription = new TableRow (this);
				TextView descriptionText = new TextView (this);
				descriptionText.SetTextAppearance(this, global::Android.Resource.Style.TextAppearanceMedium);
				descriptionText.Text = getRxSegmentDescription (thisWorkout.segments [i]);
				Console.WriteLine("Description text: " + descriptionText.Text);
				segmentDescription.AddView (descriptionText);

				//Initial call to load RX Video Links
				loadRxVideos (thisWorkout.segments[i]);

				workoutDetailsLayout.AddView (segmentHeader);
				workoutDetailsLayout.AddView (segmentDescription);
			}

			//Has to be at the end to add to video cue.
			movementVideos.Initialize (DeveloperKey.key, this);

			timerButton.Click += (sender, e) => startTimer ();

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

		void timerButtonClick(object sender, EventArgs e) {

		}

		private void startTimer() {

		}

		private String getRxSegmentDescription(WorkoutSegment segment) {
			String s = segment.segmentDescription;
			for(int j = 0; j< segment.segmentMovements.Length; j++) {
				s = s + "\n \t\u2022 " + segment.movementDescriptions[j]+ " " + segment.segmentMovements [j].name;
				Console.WriteLine ("Movement name: " + segment.segmentMovements [j].name);
				Console.WriteLine ("j = " + j.ToString ());
				Console.WriteLine ("Segment Description: " + s);
			}
			return s;
		}

		private String getBlackDiamondSegmentDescription(WorkoutSegment segment) {
			String s = segment.segmentDescription;
			for(int j = 0; j< segment.segmentMovements.Length; j++) {
				s = s + "\n \t\u2022 " + segment.movementDescriptions[j]+ " " + segment.segmentMovements [j].blackDiamondDescription;
				Console.WriteLine ("Segment Description: " + s);
			}
			return s;
		}

		void loadRxVideos(WorkoutSegment segment) {
			foreach(Movement m in segment.segmentMovements) {
				if (m.url != null) {
					movementUrls.Add (m.url);
					Console.WriteLine ("Movement Url: " + m.url);
				}
			}
		}

		void setThisWorkout() {
			switch (Int64.Parse(workoutId)) {
			case WorkoutUtil.amandaId: //Amanda
				thisWorkout = amandaWorkout;
				headerLayout.SetBackgroundResource (Resource.Drawable.amanda);
				break;
			case WorkoutUtil.jackieId: //Jackie
				thisWorkout = jackieWorkout;
				headerLayout.SetBackgroundResource (Resource.Drawable.jackie);
				break;
			default: 
				//TODO: Add error handling
				break;
			}
			Console.WriteLine ("This workout: " + thisWorkout.workoutName);
		}

		//YOUTUBE METHODS
		protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()
		{
			return movementVideos;
		}
		public override void OnInitializationSuccess (IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored)
		{
			if (!wasRestored) {
				loadVideos(player);
			} 
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

