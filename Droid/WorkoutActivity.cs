
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
	[Activity (Label = "WorkoutActivity")]			
	public class WorkoutActivity : Activity
	{
		String [] thisWodInfo;
		private WorkoutDOM thisWorkout;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.WodPage);

			//Captures data from starting activity, loads the proper data to the page.
			String id = Intent.GetStringExtra ("workoutId");
			//TODO: Constructor corresponds to name, type, need to change somewhere.
			//thisWorkout = new WorkoutDOM (thisWodInfo [1], thisWodInfo [1]);		

			//parse thisWod for Id of workout
			//Call Azure to retrieve workout object based on Id
			//Map to the instance of a workout above - thisWorkout;
			//Load data from workout for header image, text, steps, and movement videos.
		}
	}
}

