using System;
using System.Net.Http;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Facebook;
using Xamarin.Facebook.Model;
using Xamarin.Facebook.Widget;
using Microsoft.WindowsAzure.MobileServices;


[assembly:MetaData ("com.facebook.sdk.ApplicationId", Value = "@string/facebook_app_id")]


namespace WodstarMobileApp.Droid
{
	[Activity (Theme = "@android:style/Theme.Black.NoTitleBar", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity, Request.IGraphUserCallback
	{
		//First method that is executed on app start
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Set our view from the "Login" layout resource
			//Need to load this first in order to get Facebook session status from the button
			SetContentView (Resource.Layout.Login);

			//Connect to Azure
			try {
				Azure.InitializeAzure ();
			} catch( Exception e) {
				Console.WriteLine(e);
			}

			//Get Facebook button object
			//Button fbLoginButton = FindViewById<Button> (Resource.Id.login_button);

			//If Facebook session is already open from a previous login, request user info
			if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {
				//Get user info from Facebook
				Request.ExecuteMeRequestAsync (Session.ActiveSession, this);
			} else {
				//Enable the skip button to go directly into the Main layout
				var skipButton = FindViewById<Button> (Resource.Id.startScreenButton);
				skipButton.Click += goToStart;
			}
		}//end OnCreate method

		void goToStart (object sender, EventArgs e)
		{
			//Start a new Activity for the Main layout
			StartActivity (typeof(StartScreenActivity));
		}

		//This method is required by Facebook SDK Request.IGraphUserCallback, handles callback from the Facebook button
		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			//Relay the result to the Facebook Session
			Session.ActiveSession.OnActivityResult (this, requestCode, (int)resultCode, data);

			//If a Facebook session is open, request the user's information an		
			if (Session.ActiveSession.IsOpened) {
				Request.ExecuteMeRequestAsync (Session.ActiveSession, this);
			}
		}//end OnActivityResult method

		//This method is required by Facebook SDK, is called after the Facebook user information is fetched
		public void OnCompleted (Xamarin.Facebook.Model.IGraphUser user, Response response)
		{
			// If Facebook session is open, then load the Main layout
			if (user != null) {
				//Get user information from the Facebook session
				Util.thisUser.accountType = "Facebook";
				Util.thisUser.username = user.Id;
				Util.thisUser.firstName = user.FirstName;
				Util.thisUser.lastName = user.LastName;

				//Show popup containing Facebook user info
				//AlertDialog.Builder alert = new AlertDialog.Builder (this);
				//alert.SetTitle ("Facebook session");
				//alert.SetMessage (string.Format ("User ID: {0}\nFirst name: {1}\nLast name: {2}", ThisUser.Username, ThisUser.FirstName, ThisUser.LastName));
				//alert.SetPositiveButton ("OK", (senderAlert, args) => {
					//change value write your own set of instructions
					//you can also create an event for the same in xamarin
					//instead of writing things here
				//});
				//run the alert in UI thread to display in the screen
				//alert.Show ();

				//Get or create user account in Azure
				try {
					Azure.GetUserAccount (Util.thisUser);
				} catch( Exception e) {
					Console.WriteLine(e);
				}

				//Start a new Activity for the Main layout
				StartActivity (typeof(StartScreenActivity));
			}
		}//end OnCompleted method

	}	//end class
} //end namespace
