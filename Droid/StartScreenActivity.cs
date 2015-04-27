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
using Android.Graphics;
using Xamarin.Facebook;

namespace WodstarMobileApp.Droid
{
	//Class file for start page
	[Activity (Label = "StartScreenActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class StartScreenActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Show the Main layout
			SetContentView (Resource.Layout.Main);

			ImageButton wodsButton = FindViewById<ImageButton> (Resource.Id.wodsImageButton);

			//TODO: Remove before launch - demo/testing purposes only.
			wodsButton.Click += (sender, e) => {

				StartActivity(typeof(JournalData));
			/*
				string intentWorkoutId = WorkoutUtil.benchmarkIds [WorkoutUtil.amandaName];
				string intentWorkoutName = WorkoutUtil.amandaName;
				var intent = new Intent (this, typeof(WorkoutActivity));
				intent.PutExtra ("workoutName", intentWorkoutName);
				intent.PutExtra ("workoutId", intentWorkoutId);
				StartActivity (intent);

			*/
			};

			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var hamburgerButton = FindViewById (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};

			ImageView titleButton = FindViewById<ImageView> (Resource.Id.titleTextView);
			TextView homeButton = FindViewById <TextView> (Resource.Id.homeTextView);
			TextView profileButton = FindViewById <TextView> (Resource.Id.profileTextView);
			TextView wodLibraryButton = FindViewById <TextView> (Resource.Id.wodLibraryTextView);
			TextView movementLibraryButton = FindViewById <TextView> (Resource.Id.movementLibraryTextView);
			TextView logoutButton = FindViewById <TextView> (Resource.Id.logoutTextView);

			titleButton.Click += goToHomeScreen;
			homeButton.Click += goToHomeScreen;
			profileButton.Click += goToUserProfile;
			wodLibraryButton.Click += goToWodLibrary;
			movementLibraryButton.Click += goToMovementLibrary;
			logoutButton.Click += goToLogin;
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

