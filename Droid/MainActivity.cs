using System;
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
using System.Net.Http;

[assembly:Permission (Name = Android.Manifest.Permission.Internet)]
[assembly:Permission (Name = Android.Manifest.Permission.WriteExternalStorage)]
[assembly:MetaData ("com.facebook.sdk.ApplicationId", Value = "@string/facebook_app_id")]


namespace WodstarMobileApp.Droid
{
	[Activity (Theme = "@android:style/Theme.Black.NoTitleBar", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : Activity, Request.IGraphUserCallback
	{
		//Class variables
		public static string accountType { get; set; }
		public static string email { get; set; }
		public static string firstName { get; set; }
		public static string gender { get; set; }
		public static string lastName { get; set; }
		public static string userId { get; set; }
		public static string username { get; set; }

		//First method that is executed
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Set our view from the "Login" layout resource
			//Need to load this first in order to get Facebook session status from the button
			SetContentView (Resource.Layout.Login);

			//Connect to Azure and instantiate tables
			Azure.initializeAzure ();

			//Get Facebook button object
			//Button fbLoginButton = FindViewById<Button> (Resource.Id.login_button);

			//If Facebook session is already open from a previous login, then load the Main layout
			if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {
				//Start a new Activity for the Main layout
				StartActivity (typeof(StartScreenActivity));
			} else {
				var skipButton = FindViewById<Button> (Resource.Id.startScreenButton);
				skipButton.Click += goToStart;
			}
		}//end OnCreate method

		void goToStart (object sender, EventArgs e)
		{
			//Start a new Activity for the Main layout
			StartActivity (typeof(StartScreenActivity));
		}

		//This method is required by Request.IGraphUserCallback
		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			//Relay the result to our FB Session
			Session.ActiveSession.OnActivityResult (this, requestCode, (int)resultCode, data);

			//If a Facebook session is open, request the user's information an		
			if (Session.ActiveSession.IsOpened) {
				Request.ExecuteMeRequestAsync (Session.ActiveSession, this);
			}
		}//end OnActivityResult method

		//This method is called after the Facebook user information is fetched
		public void OnCompleted (Xamarin.Facebook.Model.IGraphUser user, Response response)
		{
			// If Facebook session is open, then load the Main layout
			if (user != null) {
				//Get user information from the Facebook session
				accountType = "Facebook";
				username = user.Id;
				firstName = user.FirstName;
				lastName = user.LastName;

				//set alert for executing the task
				AlertDialog.Builder alert = new AlertDialog.Builder (this);
				alert.SetTitle ("Facebook session");
				alert.SetMessage (string.Format ("User ID: {0}\nFirst name: {1}\nLast name: {2}", username, firstName, lastName));
				alert.SetPositiveButton ("OK", (senderAlert, args) => {
					//change value write your own set of instructions
					//you can also create an event for the same in xamarin
					//instead of writing things here
				});
				//alert.SetNegativeButton ("Not doing great", (senderAlert, args) => {
				//perform your own task for this conditional button click
				//} );
				//run the alert in UI thread to display in the screen
				alert.Show ();

				//Get or create user account in Azure
				Azure.userAccount (username);

				//Start a new Activity for the Main layout
				StartActivity (typeof(StartScreenActivity));
			}
		}//end OnCompleted method
	}	//end class
} //end namespace
