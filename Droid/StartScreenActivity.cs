
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
	//Class file for start page
	[Activity (Label = "StartScreenActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class StartScreenActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Main);

			var wodsTextView = FindViewById<TextView> (Resource.Id.wodsTextView);
			wodsTextView.Click += goToMovementLibrary;

			var statsTextView = FindViewById<TextView> (Resource.Id.statsTextView);
			statsTextView.Click += goToUserProfile;

			var hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click += goToHomeScreen;

		}

		void goToUserProfile(object sender, EventArgs e) {
			StartActivity (typeof(UserProfileActivity));
		}

		void goToHomeScreen(object sender, EventArgs e) {
			StartActivity (typeof(StartScreenActivity));
		}

		void goToMovementLibrary(object sender, EventArgs e) {
			StartActivity(typeof(MovementLibraryActivity));
		}
			
	}
}

