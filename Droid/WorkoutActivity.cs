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
using com.refractored.monodroidtoolkit;
using System.Threading.Tasks;

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
		private Button timerButton;
		private HoloCircularProgressBar progressBar;
		private bool timerStarted;
		private HoloCircularProgressBar circularProgressBar;
		private Button logButton;
		private Button restartButton;
		int blueWodstarColor = Android.Graphics.Color.Argb (1, 46, 67, 89);
		int redWodstarColor = Android.Graphics.Color.Argb (1, 181, 25, 29);
		int thisSegment =0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			//Get all the changeable sections of the layout.
			TableLayout workoutDetailsLayout = FindViewById<TableLayout> (Resource.Id.workoutDetailsLayout);
			movementVideos = (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.movementVideos);
			circularProgressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);
			headerLayout = FindViewById<FrameLayout> (Resource.Id.headerLayout);
			timerButton = FindViewById<Android.Widget.Button> (Resource.Id.timerButton);
			progressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);
			logButton = FindViewById<Android.Widget.Button> (Resource.Id.logButton);
			restartButton = FindViewById<Android.Widget.Button> (Resource.Id.restartButton);

			restartButton.Click += (sender, e) => {resetTimer();}; 
			logButton.Click += (sender, e) => {	//logData();
			};

			//Captures data from starting activity, loads the proper data to the page.
			workoutId = Intent.GetStringExtra ("workoutId");
			setThisWorkout ();

			logButton.Visibility = ViewStates.Invisible;
			restartButton.Visibility = ViewStates.Invisible;

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

			timerButton.Click += timerButtonClick;

			//MENU METHODS
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
			//END MENU METHODS

		} //End onCreate

		void timerButtonClick(object sender, EventArgs e) {
			if (!timerStarted) {
				startTimer ();
			} else {
				stopTimer ();
			}
		}

		private async void startAmrapTimer(int minutes) {
			resetTimer ();
			timerStarted = true;

			circularProgressBar.IndeterminateInterval = 320;
			circularProgressBar.Indeterminate=true;

			int minutesPassed = 0;
			int secondsPassed = 0;
			int millisecondsPassed = 0;
			int secondsText = 0;
			int millisecondsText = 0;
			int minutesText =0;
			TimeSpan delayTimeSpan = new TimeSpan (0, 0, 0, 0, 100);

			while(timerStarted) {
				await Task.Delay(delayTimeSpan);
				millisecondsPassed+=1;
				if(millisecondsPassed>=10) {
					secondsPassed+=1;
					millisecondsPassed = 0;
				}
				if(secondsPassed>=60) {
					minutesPassed+=1;
					secondsPassed = 0;
				}
				if(millisecondsPassed==0) {
					millisecondsText = 0;
				} else {
					millisecondsText = 10 - millisecondsPassed;
				}
				if(secondsPassed==0) {
					secondsText = 0;
				} else {
					secondsText = 60 - secondsPassed;
				}
				if (minutes - minutesPassed <0) {
					minutesText = 0;
				}else if(minutes==1) {
					if (secondsPassed==0) {
						minutesText = 1;
					} else {
						minutesText = 0;
					}
				} else {
					minutesText = minutes - minutesPassed;
				}
				timerButton.Text = minutesText.ToString("D2") + ":" + secondsText.ToString("D2") + "." + millisecondsText.ToString("D2");
				if(minutesPassed==minutes-1) {
					circularProgressBar.ProgressColor = redWodstarColor;
				}else if(minutesPassed == minutes) {
					stopTimer ();
				}
			}
		} //end startCountdownTimer()

		private void startTimer() {
			resetTimer ();
			timerStarted = true;
			circularProgressBar.ProgressColor = Android.Graphics.Color.DarkBlue.ToArgb();
			circularProgressBar.CircleStrokeWidth = 20;
			circularProgressBar.Progress = 0;

	/*		if(thisWorkout.segments[thisSegment].segmentType == WorkoutUtil.forTimeType) {
				startStopwatchTimer ();
			} else if (thisWorkout.segments[thisSegment].segmentType == WorkoutUtil.amrapType) {
				startAmrapTimer (thisWorkout.segments [thisSegment].time); 
			} else if (thisWorkout.segments[thisSegment].segmentType == WorkoutUtil.emomType) {
				startEmomTimer(thisWorkout.segments [thisSegment].time, thisWorkout.segments[thisSegment].repetitions);
			}
	*/
			startAmrapTimer (2);
			
		}//End startTimer()

		private async void startStopwatchTimer() {
			circularProgressBar.Indeterminate = true;
			int minutes = 0;
			int seconds = 0;
			int milliseconds = 0;
			TimeSpan delayTimeSpan = new TimeSpan (0, 0, 0, 0, 100);

			while(timerStarted) {
				await Task.Delay(delayTimeSpan);
				milliseconds+=1;
				if(milliseconds>=10) {
					seconds+=1;
					milliseconds = 0;
				}
				if(seconds>=60) {
					minutes+=1;
					seconds = 0;
				}
				timerButton.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2") + "." + milliseconds.ToString("D2");
			}
		}

		private void stopTimer() {
			timerStarted = false;
			circularProgressBar.Indeterminate = false;
			logButton.Visibility = ViewStates.Visible;
			restartButton.Visibility = ViewStates.Visible;
		}

		private void resetTimer() {
			logButton.Visibility = ViewStates.Invisible;
			restartButton.Visibility = ViewStates.Invisible;
			timerButton.Text = "0:00.00";
		}

		private void logData(int workoutId, int finalScore) {
			//If for time, final score should be passed in seconds with 2 decimal places
			//If AMRAP, should be passed as total number of reps.
			//If EMOM, should be total number of completed minutes
		}

		private String getRxSegmentDescription(WorkoutSegment segment) {
			String s = segment.segmentDescription;
			for(int j = 0; j< segment.segmentMovementsArray.Length; j++) {
				s = s + "\n \t\u2022 " + segment.movementDescriptionsArray[j]+ " " + segment.segmentMovementsArray [j].name;
				Console.WriteLine ("Movement name: " + segment.segmentMovementsArray [j].name);
				Console.WriteLine ("j = " + j.ToString ());
				Console.WriteLine ("Segment Description: " + s);
			}
			return s;
		}

		private String getBlackDiamondSegmentDescription(WorkoutSegment segment) {
			String s = segment.segmentDescription;
			for(int j = 0; j< segment.segmentMovementsArray.Length; j++) {
				s = s + "\n \t\u2022 " + segment.movementDescriptionsArray[j]+ " " + segment.segmentMovementsArray [j].blackDiamondDescription;
				Console.WriteLine ("Segment Description: " + s);
			}
			return s;
		}

		void loadRxVideos(WorkoutSegment segment) {
			foreach(Movement m in segment.segmentMovementsArray) {
				if (m.rxVideoUrl != null) {
					movementUrls.Add (m.rxVideoUrl);
					Console.WriteLine ("Movement Url: " + m.rxVideoUrl);
				}
			}
		}
			
		void setThisWorkout() {
			Console.WriteLine ("setThisWorkout() called");
			if (WorkoutUtil.benchmarkWods.ContainsKey (workoutId)) {
				Console.WriteLine ("Benchmark Wods contains key for workoutID");
				thisWorkout = WorkoutUtil.benchmarkWods [workoutId];
			} else if (WorkoutUtil.heroWods.ContainsKey (workoutId)) {
				Console.WriteLine ("HeroWods contains key for workoutID");
				thisWorkout = WorkoutUtil.heroWods [workoutId];
			} else if (WorkoutUtil.camilleWods.ContainsKey(workoutId)) {
				thisWorkout = WorkoutUtil.camilleWods [workoutId];
			} else if (WorkoutUtil.wodstarWods.ContainsKey(workoutId)) {
				thisWorkout = WorkoutUtil.wodstarWods [workoutId];
			} else {
				Console.WriteLine ("No ID dictionary found that contains this workoutkey");
			}
			if (thisWorkout.workoutType == WorkoutUtil.heroType) {
				if (WorkoutUtil.stringHeroWods.Contains (thisWorkout.workoutName)) {
					headerLayout.SetBackgroundResource (Resource.Drawable.american);
				} else if (WorkoutUtil.canadaHeroWods.Contains (thisWorkout.workoutName)) {
					headerLayout.SetBackgroundResource (Resource.Drawable.canadian);
				} else {
					headerLayout.SetBackgroundResource (Resource.Drawable.australian);
				}
			} else if (thisWorkout.workoutType == WorkoutUtil.benchmarkType) {
				Console.WriteLine ("thisWorkout.workoutType = WorkoutUtil.benchmarkType");
				switch (workoutId) {
				case WorkoutUtil.amandaId: //Amanda
					headerLayout.SetBackgroundResource (Resource.Drawable.amanda);
					break;
				case WorkoutUtil.jackieId: //Jackie
					headerLayout.SetBackgroundResource (Resource.Drawable.jackie);
					break;
				default: 
			//TODO: Add error handling
					break;
				}
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

