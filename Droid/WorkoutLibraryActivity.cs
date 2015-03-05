
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
	[Activity (Label = "WorkoutLibraryActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class WorkoutLibraryActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodLibrary);
			// Create your application here

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
			ImageButton elizabethButton = FindViewById<ImageButton> (Resource.Id.elizabethButton);
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
				maryButton.Click += goToMaryWod;
			ImageButton joshuaButton = FindViewById<ImageButton> (Resource.Id.joshuaButton);
				joshuaButton.Click += goToJoshuaWod;
		} // End on create

		void goToAmandaWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.amandaId);
			intent.PutExtra("workoutName", "amanda");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToJackieWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.jackieId);
			intent.PutExtra("workoutName", "jackie");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToKellyWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.kellyId);
			intent.PutExtra("workoutName", "kelly");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToHelenWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.helenId);
			intent.PutExtra("workoutName", "helen");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToKarenWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.karenId);
			intent.PutExtra("workoutName", "karen" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToIsabelWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.isabelId);
			intent.PutExtra("workoutName", "isabel");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToGraceWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.graceId);
			intent.PutExtra("workoutName", "grace");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToFranWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.franId);
			intent.PutExtra("workoutName", "fran");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToElizabethWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.elizabethId);
			intent.PutExtra("workoutName", "elizabeth");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToDianeWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.dianeId);
			intent.PutExtra("workoutName", "diane");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToCindyWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.cindyId);
			intent.PutExtra("workoutName", "cindy");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToChelseaWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.chelseaId);
			intent.PutExtra("workoutName","chelsea" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToAnnieWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.annieId);
			intent.PutExtra("workoutName", "annie" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToChristineWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.christineId);
			intent.PutExtra("workoutName", "christine" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToBarbaraWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.barbaraId);
			intent.PutExtra("workoutName", "barbara");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToAngieWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.angieId);
			intent.PutExtra("workoutName", "angie");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToMaryWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.maryId);
			intent.PutExtra("workoutName", "mary");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToJoshuaWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WodstarMobileApp.WorkoutLinks.joshuaId);
			intent.PutExtra("workoutName", "joshua");
			StartActivity(typeof(WorkoutActivity));
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

	} //End class
} //End namespace
