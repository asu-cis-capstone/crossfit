﻿
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
	[Activity (Label = "WorkoutActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class WorkoutActivity : Activity
	{
		public Workout thisWorkout= new Workout();

		//Sample workout
		private WorkoutSegment amanda1 = new WorkoutSegment (WorkoutUtil.forTime, "Description", "3 Rounds for time of 9-7-5 reps of:", 
			1, MovementLinks.ringMuscleUpMovement, MovementLinks.squatSnatchMovement);
		private Workout amandaWorkout = new Workout ("Amanda", amanda1);

		private WorkoutSegment jackieSegment = new WorkoutSegment (WorkoutUtil.forTime, "Description", 
           "Complete the following for time:\n\n1,000 meter Row\n50 Thrusters (45/35)\n30 Pull-ups", 1, MovementLinks.rowingMovement, MovementLinks.thrusterMovement, 
           MovementLinks.pullUpMovement);
		private Workout jackieWorkout = new Workout ("Jackie", jackieSegment);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			//Captures data from starting activity, loads the proper data to the page.
			String id = Intent.GetStringExtra ("workoutId");
			//Based off ID, fetch workout and assign it to this workout.

			//Get all the changeable sections of the layout.
			TextView wodHeaderText = FindViewById<TextView> (Resource.Id.wodHeaderText);
			ImageView wodImage = FindViewById<ImageView> (Resource.Id.wodstarImage);
			TableLayout workoutDetailsLayout = FindViewById<TableLayout> (Resource.Id.workoutDetailsLayout);

			//Assign thisWorkout value.
			switch (Int64.Parse(id)) {
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

			wodHeaderText = thisWorkout.workoutName;
			for(int i=0;i <thisWorkout.segments.Count; i++) {
				TableRow segmentHeader = new TableRow (thisWorkout.segments[i].segmentHeader);
				TableRow segmentDescription = new TableRow (thisWorkout.segments[i].segmentDescription);
				workoutDetailsLayout.AddView (segmentHeader);
				workoutDetailsLayout.AddView (segmentDescription);
			}

				
			//Load data from workout for header image, text, steps, and movement videos.

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

		void createMovementVideo(String url) {
			//Take in movement video url and create Youtube fragment for it.
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

