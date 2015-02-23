
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
	[Activity (Label = "UserProfileActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class UserProfileActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.UserProfile);

			//Code to go get Azure data - should be housed in non-OS specific code. 

			var hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click +=goToHomeScreen;
		}

		void goToHomeScreen(object sender, EventArgs e) {
			//Start a new Activity for the Main layout
			StartActivity (typeof(StartScreenActivity));
		}
	}
}

