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
[assembly:MetaData ("com.facebook.sdk.ApplicationId", Value ="@string/facebook_app_id")]


namespace WodstarMobileApp.Droid
{
	[Activity (Theme="@android:style/Theme.Black.NoTitleBar", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : Activity, Session.IStatusCallback, Request.IGraphUserCallback
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Set our view from the "Login" layout resource
			//Need to load this first in order to get Facebook session status from the button
			SetContentView (Resource.Layout.Login);

			//Connect to Azure and instantiate tables
			Util.initializeTables();

			//Get Facebook button object
			//Button fbLoginButton = FindViewById<Button> (Resource.Id.login_button);

			//If Facebook session is already open from a previous login, then load the Main layout
			if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {
				// Set our view from the "Main" layout resource
				SetContentView (Resource.Layout.Main);
			}

			var skipButton = FindViewById<Button> (Resource.Id.startScreenButton);
			skipButton.Click += goToStart;
		}//end OnCreate method

		void goToStart(object sender, EventArgs e) {
			StartActivity (typeof(StartScreenActivity));
		}

		public static MobileServiceClient MobileService = new MobileServiceClient (
			"https://wodstar-helloworld.azure-mobile.net/",
			"VESEBrXxDLeGQSOwHEqnNxtKmYyQDJ98"
		);

		//This method is required by Request.IGraphUserCallback
		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			//Relay the result to our FB Session
			Session.ActiveSession.OnActivityResult (this, requestCode, (int)resultCode, data);

			//If a Facebook session is open, request the user's information
			if (Session.ActiveSession.IsOpened) {
				Request.ExecuteMeRequestAsync (Session.ActiveSession, this);
			}
		}//end OnActivityResult method

		//This method is required by Session.IStatusCallback
		public void Call (Session session, SessionState state, Java.Lang.Exception exception)
		{
			
		}//end Call method

		//This method is called after the Facebook user information is fetched
		public void OnCompleted (Xamarin.Facebook.Model.IGraphUser user, Response response)
		{
			// If Facebook session is open, then load the Main layout
			if (user != null) {
				// Set our view from the "Main" layout resource
				SetContentView (Resource.Layout.Main);
			}
		}//end OnCompleted method

	} //end class
} //end namespace
