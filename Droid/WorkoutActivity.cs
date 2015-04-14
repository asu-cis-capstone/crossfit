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
		public bool colorIsRed=true;
		static Android.Graphics.Color blue = Android.Graphics.Color.Argb(1, 46, 67, 89);
		static Android.Graphics.Color red = Android.Graphics.Color.Argb(0, 181, 25, 29);
		int blueWodstarColor = Android.Graphics.Color.RoyalBlue;
		int redWodstarColor = Android.Graphics.Color.Red;
		int whiteColor = Android.Graphics.Color.Snow;
		LinearLayout buttonLayout;
		int amrapResult =0;

		private List<WorkoutSegment> segments;
		int thisSegment =0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			segments = new List<WorkoutSegment> ();

			//Get all the changeable sections of the layout.
			TableLayout workoutDetailsLayout = FindViewById<TableLayout> (Resource.Id.workoutDetailsLayout);
			movementVideos = (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.movementVideos);
			circularProgressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);
			headerLayout = FindViewById<FrameLayout> (Resource.Id.headerLayout);
			timerButton = FindViewById<Android.Widget.Button> (Resource.Id.timerButton);
			progressBar = FindViewById<HoloCircularProgressBar> (Resource.Id.circularProgressBar);
			logButton = FindViewById<Android.Widget.Button> (Resource.Id.logButton);
			restartButton = FindViewById<Android.Widget.Button> (Resource.Id.restartButton);
			buttonLayout = FindViewById<LinearLayout> (Resource.Id.buttonLayout);
			logButton.Visibility = ViewStates.Invisible;
			restartButton.Visibility = ViewStates.Invisible;
			restartButton.Click += (sender, e) => {resetTimer();}; 
			logButton.Click += (sender, e) => {	//logData();
			};

			//Captures data from starting activity, loads the proper data to the page.
			workoutId = Intent.GetStringExtra ("workoutId");
			setThisWorkout ();

			//Dynamically load workout content
			for(int i=0;i <segments.Count; i++) {
				TableRow segmentHeader = new TableRow (this);
				TextView headerText = new TextView (this);
				headerText.Text =segments [i].segmentHeader;
				headerText.SetTextAppearance (this, global::Android.Resource.Style.TextAppearanceLarge);
				segmentHeader.AddView (headerText);

				TableRow segmentDescription = new TableRow (this);
				TextView descriptionText = new TextView (this);
				descriptionText.SetTextAppearance(this, global::Android.Resource.Style.TextAppearanceMedium);
				descriptionText.Text = getRxSegmentDescription (segments [i]);
				Console.WriteLine("Description text: " + descriptionText.Text);
				segmentDescription.AddView (descriptionText);

				//Initial call to load RX Video Links
				loadRxVideos (segments[i]);
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
			//TODO: Add some kind of error handling.
			if (minutes >= 1) {
				resetTimer ();
				timerStarted = true;

				bool initial = true;
				int minutesPassed = 0;
				int secondsPassed = 0;
				int millisecondsPassed = 0;
				int secondsText = 0;
				int millisecondsText = 0;
				int minutesText = 0;
				TimeSpan delayTimeSpan = new TimeSpan (0, 0, 0, 0, 100);

				while (timerStarted) {
					await Task.Delay (delayTimeSpan);
					millisecondsPassed += 1;
					if (millisecondsPassed >= 10) {
						secondsPassed += 1;
						millisecondsPassed = 0;
					}
					if (secondsPassed >= 60) {
						minutesPassed += 1;
						secondsPassed = 0;
					}

					if (initial) {
						minutesText = minutes;
						if(millisecondsPassed!=0) {
							secondsPassed+=1;
						}
						initial = false;
					} else if(minutesPassed == 0 && !initial){
						minutesText = minutes - 1;
					} else {
						minutesText = minutes - minutesPassed - 1;
					}

					if (millisecondsPassed == 0) {
						millisecondsText = 0;
					} else {
						millisecondsText = 10 - millisecondsPassed;
					}
					if (secondsPassed == 0) {secondsText = 0;}
						else {secondsText = 60 - secondsPassed;}
											
					timerButton.Text = Math.Abs(minutesText).ToString ("D2") + ":" + secondsText.ToString ("D2") + "." + millisecondsText.ToString ("D2");

					//Change color of bar to red in last minute, stop if out of time.
					if (minutesPassed == minutes - 1) {
						circularProgressBar.ProgressColor = redWodstarColor;
						//Flash on last five seconds.
						if (secondsPassed >=55) {
							if (millisecondsPassed % 5 == 0) {
								circularProgressBar.ProgressColor = flashColor ();
							} 
						}
					} else if (minutesPassed == minutes) {
						stopTimer ();
					}
				}
			}
		} //end startCountdownTimer()

		private int flashColor() {
			if(colorIsRed) {
				return whiteColor;
			} else {
				return redWodstarColor;
			}
		}

		private void startCountdown() {
			//TODO: Implement countdown functionality
		}

		private void startTimer() {
			resetTimer ();
			timerStarted = true;
			circularProgressBar.ProgressColor = blueWodstarColor;
			circularProgressBar.CircleStrokeWidth = 20;
			circularProgressBar.Progress = 0;
			if(segments[thisSegment].segmentType == WorkoutUtil.forTimeType) {
				startStopwatchTimer ();
			} else if (segments[thisSegment].segmentType == WorkoutUtil.amrapType) {
				startAmrapTimer (segments [thisSegment].time); 
			} else if (segments[thisSegment].segmentType == WorkoutUtil.emomType) {
				//TODO: Implement EMOM timer
			//	startEmomTimer(segments [thisSegment].time, segments[thisSegment].repetitions);
			}
			circularProgressBar.IndeterminateInterval = 320;
			circularProgressBar.Indeterminate=true;	
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
			timerStarted = false;
			logButton.Visibility = ViewStates.Invisible;
			restartButton.Visibility = ViewStates.Invisible;
			timerButton.Text = "0:00.00";
		}

		private void logData(int workoutId, int finalScore) {
			//TODO: Implement logging functionality
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
			getThisWorkoutSegments (workoutId);
			setHeader ();
			Console.WriteLine ("This workout: " + thisWorkout.workoutName);
		}
			
		private void getThisWorkoutSegments(string workoutId) {
			foreach(WorkoutSegment s in WorkoutUtil.allSegments) {;
				if(s.workoutId == thisWorkout.id) {
					s.parseMovements ();
					segments.Add (s);
				}
			}
		}

		private void setHeader() {
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
				case WorkoutUtil.kellyId:
					headerLayout.SetBackgroundResource (Resource.Drawable.kelly);
					break;
				case WorkoutUtil.elizabethId:
					headerLayout.SetBackgroundResource (Resource.Drawable.elizabeth);
					break;
				case WorkoutUtil.helenId:
					headerLayout.SetBackgroundResource (Resource.Drawable.helen);
					break;
				case WorkoutUtil.karenId:
					headerLayout.SetBackgroundResource (Resource.Drawable.karen);
					break;
				case WorkoutUtil.isabelId:
					headerLayout.SetBackgroundResource (Resource.Drawable.isabel);
					break;
				case WorkoutUtil.franId:
					headerLayout.SetBackgroundResource (Resource.Drawable.fran);
					break;
				case WorkoutUtil.nicoleId:
					headerLayout.SetBackgroundResource (Resource.Drawable.nicole);
					break;
				case WorkoutUtil.graceId:
					headerLayout.SetBackgroundResource (Resource.Drawable.grace);
					break;
				case WorkoutUtil.dianeId:
					headerLayout.SetBackgroundResource (Resource.Drawable.diane);
					break;
				case WorkoutUtil.cindyId:
					headerLayout.SetBackgroundResource (Resource.Drawable.cindy);
					break;
				case WorkoutUtil.chelseaId:
					headerLayout.SetBackgroundResource (Resource.Drawable.chelsea);
					break;
				case WorkoutUtil.annieId:
					headerLayout.SetBackgroundResource (Resource.Drawable.annie);
					break;
				case WorkoutUtil.christineId:
					headerLayout.SetBackgroundResource (Resource.Drawable.christine);
					break;
				//TODO: uncomment after adding in barbara photo
				/*	case WorkoutUtil.barbaraId:
						headerLayout.SetBackgroundResource (Resource.Drawable.barbara);
						break;
				*/
				case WorkoutUtil.angieId:
					headerLayout.SetBackgroundResource (Resource.Drawable.angie);
					break;
				case WorkoutUtil.maryId:
					headerLayout.SetBackgroundResource (Resource.Drawable.mary);
					break;
				case WorkoutUtil.nancyId:
					headerLayout.SetBackgroundResource (Resource.Drawable.nancy);
					break;
				case WorkoutUtil.evaId:
					headerLayout.SetBackgroundResource (Resource.Drawable.eva);
					break;
				case WorkoutUtil.lindaId:
					headerLayout.SetBackgroundResource (Resource.Drawable.linda);
					break;
				case WorkoutUtil.rosaId:
					headerLayout.SetBackgroundResource (Resource.Drawable.rosa);
					break;
				default: 
					//TODO: Add error handling
					break;
				}
			}
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

