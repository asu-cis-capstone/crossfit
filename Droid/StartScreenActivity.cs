
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
using Xamarin.Facebook

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

			//Initialize FB profile picture data


			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var hamburgerButton = FindViewById (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};

			TextView titleButton = FindViewById<TextView> (Resource.Id.titleTextView);
			TextView homeButton = FindViewById <TextView> (Resource.Id.homeTextView);
			TextView profileButton = FindViewById <TextView> (Resource.Id.profileTextView);
			TextView journalButton = FindViewById <TextView> (Resource.Id.journalTextView);
			TextView wodLibraryButton = FindViewById <TextView> (Resource.Id.wodLibraryTextView);
			TextView movementLibraryButton = FindViewById <TextView> (Resource.Id.movementLibraryTextView);
			TextView logoutButton = FindViewById <TextView> (Resource.Id.logoutTextView);

			titleButton.Click += goToHomeScreen;
			homeButton.Click += goToHomeScreen;
			profileButton.Click += goToUserProfile;
			journalButton.Click += goToJournal;
			wodLibraryButton.Click += goToWodLibrary;
			movementLibraryButton.Click += goToMovementLibrary;
			logoutButton.Click += goToLogin;

			Typeface font = Typeface.CreateFromAsset (Assets, "Font/montserrat.ttf");
			titleButton.Typeface = font;
			homeButton.Typeface = font;
			profileButton.Typeface = font;
			journalButton.Typeface = font;
			wodLibraryButton.Typeface = font;
			movementLibraryButton.Typeface = font;
			logoutButton.Typeface = font;
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

