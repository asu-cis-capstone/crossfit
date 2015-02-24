
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
			ImageButton jackieButton = FindViewById<ImageButton> (Resource.Id.jackieButton);
			ImageButton kellyButton = FindViewById<ImageButton> (Resource.Id.kellyButton);
		}

		void goToAmandaWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.amandaId);
			intent.PutExtra("workoutName", "amanda");
			StartActivity(WorkoutActivity);
		}
		void goToJackieWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.jackieId);
			intent.PutExtra("workoutName", "jackie");
			StartActivity(WorkoutActivity);
		}
		void goToKellyWod(object sender, EventArgs e) {
			var intent = new Intent (this, typeof(WorkoutActivity));
			intent.PutExtra("workoutId", WorkoutLinks.kellyId);
			intent.PutExtra("workoutName", "kelly");
			StartActivity(WorkoutActivity);
		}
	}
}

