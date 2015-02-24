
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
		}
	}
}

