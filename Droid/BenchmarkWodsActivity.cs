
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
	[Activity (Label = "BenchmarkWodsActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class BenchmarkWodsActivity : Activity
	{
		AutoCompleteTextView autocompleteBenchmark;
		string intentWorkoutName;
		string intentWorkoutId;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.BenchmarkWods);

			autocompleteBenchmark = FindViewById<AutoCompleteTextView> (Resource.Id.autocompleteBenchmark);
			var adapter = new ArrayAdapter<String> (this, Resource.Layout.AutcompleteTextViewTemplate, WorkoutUtil.stringBenchmarkWods);
			autocompleteBenchmark.Adapter = adapter;
			autocompleteBenchmark.SetSelectAllOnFocus (true);
			autocompleteBenchmark.Threshold = 1;
			autocompleteBenchmark.SetText ("Search", false);
			autocompleteBenchmark.ItemClick += searchItemSelected;
			autocompleteBenchmark.ClearFocus ();

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

			ImageButton amandaButton = FindViewById<ImageButton> (Resource.Id.amandaButton);
			amandaButton.Click += goToAmandaWod;
			ImageButton jackieButton = FindViewById<ImageButton> (Resource.Id.jackieButton);
			jackieButton.Click += goToJackieWod;
			ImageButton kellyButton = FindViewById<ImageButton> (Resource.Id.kellyButton);
			kellyButton.Click += goToKellyWod;
			ImageButton helenButton = FindViewById<ImageButton> (Resource.Id.helenButton);
			helenButton.Click += goToHelenWod;
			ImageButton karenButton = FindViewById<ImageButton> (Resource.Id.karenButton);
			karenButton.Click += goToKarenWod;
			ImageButton isabelButton = FindViewById<ImageButton> (Resource.Id.isabelButton);
			isabelButton.Click += goToIsabelWod;
			ImageButton graceButton = FindViewById<ImageButton> (Resource.Id.graceButton);
			graceButton.Click += goToGraceWod;
			ImageButton franButton = FindViewById<ImageButton> (Resource.Id.franButton);
			franButton.Click += goToFranWod;
	/*		ImageButton elizabethButton = FindViewById<ImageButton> (Resource.Id.elizabethButton);
			elizabethButton.Click += goToElizabethWod;
			ImageButton dianeButton = FindViewById<ImageButton> (Resource.Id.dianeButton);
			dianeButton.Click += goToDianeWod;
			ImageButton cindyButton = FindViewById<ImageButton> (Resource.Id.cindyButton);
			cindyButton.Click += goToCindyWod;
			ImageButton chelseaButton = FindViewById<ImageButton> (Resource.Id.chelseaButton);
			chelseaButton.Click += goToChelseaWod;
			ImageButton annieButton = FindViewById<ImageButton> (Resource.Id.annieButton);
			annieButton.Click += goToAnnieWod;
			ImageButton christineButton = FindViewById<ImageButton> (Resource.Id.christineButton);
			christineButton.Click += goToChristineWod;
			ImageButton barbaraButton = FindViewById<ImageButton> (Resource.Id.barbaraButton);
			barbaraButton.Click += goToBarbaraWod;
			ImageButton angieButton = FindViewById<ImageButton> (Resource.Id.angieButton);
			angieButton.Click += goToAngieWod;
			ImageButton maryButton = FindViewById<ImageButton> (Resource.Id.maryButton);
			maryButton.Click += goToMaryWod; */
		} // End on create

		void searchItemSelected(object sender, AdapterView.ItemClickEventArgs e) {
			String workoutSelected = autocompleteBenchmark.Text;
			if(WorkoutUtil.benchmarkIds.ContainsKey(workoutSelected)) {
				intentWorkoutId = WorkoutUtil.benchmarkIds [workoutSelected];
				intentWorkoutName = workoutSelected;
				goToWorkout ();
			}
		}

		void goToWorkout() {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra ("workoutName", intentWorkoutName);
			intent.PutExtra ("workoutId", intentWorkoutId);
			StartActivity (intent);
		}

		void goToAmandaWod(object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.amandaName];
			intentWorkoutName = WorkoutUtil.amandaName;
			goToWorkout ();
		}
		void goToJackieWod(object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.jackieName];
			intentWorkoutName = WorkoutUtil.jackieName;
			goToWorkout ();
		}
		void goToKellyWod(object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.nicoleId];
			intentWorkoutName = WorkoutUtil.nicoleName;
			goToWorkout ();
		}
		void goToHelenWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.helenName];
			intentWorkoutName = WorkoutUtil.helenName;
			goToWorkout ();
		}
		void goToKarenWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.karenName];
			intentWorkoutName = WorkoutUtil.karenName;
			goToWorkout ();
		}
		void goToIsabelWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.isabelName];
			intentWorkoutName = WorkoutUtil.isabelName;
			goToWorkout ();
		}
		void goToGraceWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.graceName];
			intentWorkoutName = WorkoutUtil.graceName;
			goToWorkout ();
		}
		void goToFranWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.franName];
			intentWorkoutName = WorkoutUtil.franName;
			goToWorkout ();
		}
		void goToElizabethWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.elizabethName];
			intentWorkoutName = WorkoutUtil.elizabethName;
			goToWorkout ();
		}
		void goToDianeWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.dianeName];
			intentWorkoutName = WorkoutUtil.dianeName;
			goToWorkout ();
		}
		void goToCindyWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.cindyName];
			intentWorkoutName = WorkoutUtil.cindyName;
			goToWorkout ();
		}
		void goToChelseaWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.chelseaName];
			intentWorkoutName = WorkoutUtil.chelseaName;
			goToWorkout ();
		}
		void goToAnnieWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.annieName];
			intentWorkoutName = WorkoutUtil.annieName;
			goToWorkout ();
		}
		void goToChristineWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.christineName];
			intentWorkoutName = WorkoutUtil.christineName;
			goToWorkout ();
		}
		void goToBarbaraWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.barbaraName];
			intentWorkoutName = WorkoutUtil.barbaraName;
			goToWorkout ();
		}
		void goToAngieWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.angieName];
			intentWorkoutName = WorkoutUtil.angieName;
			goToWorkout ();
		}
		void goToMaryWod (object sender, EventArgs e) {
			intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.maryName];
			intentWorkoutName = WorkoutUtil.maryName;
			goToWorkout ();
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

