
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

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "WorkoutLibraryActivity")]			
	public class WorkoutLibraryActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodLibrary);
			// Create your application here

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
			intent.PutExtra("workoutId", WorkoutLinks.amandaId);
			intent.PutExtra("workoutName", "amanda");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToJackieWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.jackieId);
			intent.PutExtra("workoutName", "jackie");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToKellyWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.kellyId);
			intent.PutExtra("workoutName", "kelly");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToHelenWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.helenId);
			intent.PutExtra("workoutName", "helen");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToKarenWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.karenId);
			intent.PutExtra("workoutName", "karen" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToIsabelWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.isabelId);
			intent.PutExtra("workoutName", "isabel");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToGraceWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.graceId);
			intent.PutExtra("workoutName", "grace");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToFranWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.franId);
			intent.PutExtra("workoutName", "fran");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToElizabethWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.elizabethId);
			intent.PutExtra("workoutName", "elizabeth");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToDianeWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.dianeId);
			intent.PutExtra("workoutName", "diane");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToCindyWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.cindyId);
			intent.PutExtra("workoutName", "cindy");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToChelseaWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.chelseaId);
			intent.PutExtra("workoutName","chelsea" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToAnnieWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.annieId);
			intent.PutExtra("workoutName", "annie" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToChristineWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.christineId);
			intent.PutExtra("workoutName", "christine" );
			StartActivity(typeof(WorkoutActivity));
		}
		void goToBarbaraWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.barbaraId);
			intent.PutExtra("workoutName", "barbara");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToAngieWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.angieId);
			intent.PutExtra("workoutName", "angie");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToMaryWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.maryId);
			intent.PutExtra("workoutName", "mary");
			StartActivity(typeof(WorkoutActivity));
		}
		void goToJoshuaWod (object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.joshuaId);
			intent.PutExtra("workoutName", "joshua");
			StartActivity(typeof(WorkoutActivity));
		}

	} //End class
} //End namespace
