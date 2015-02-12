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
	[Activity (Theme="@android:style/Theme.Black.NoTitleBar", Label = "WodstarMobileApp.Droid", Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : Activity, Session.IStatusCallback, Request.IGraphUserCallback
	{
		public static MobileServiceClient MobileService = new MobileServiceClient (
			"https://wodstar-helloworld.azure-mobile.net/",
			"VESEBrXxDLeGQSOwHEqnNxtKmYyQDJ98"
		);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "Login" layout resource
			SetContentView (Resource.Layout.Login);

			Button fbLoginButton = FindViewById<Button> (Resource.Id.login_button);
			fbLoginButton.Click += delegate {
				fbLoginClickHandler();
			};

			// Open a FB Session and show login if necessary
			Session.OpenActiveSession (this, true, this);
		}

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			// Relay the result to our FB Session
			Session.ActiveSession.OnActivityResult (this, requestCode, (int)resultCode, data);
		}

		public void Call (Session session, SessionState state, Java.Lang.Exception exception)
		{
			// Make a request for 'Me' information about the current user
			if (session.IsOpened)
				Request.ExecuteMeRequestAsync (session, this);
		}

		public void OnCompleted (Xamarin.Facebook.Model.IGraphUser user, Response response)
		{
			// 'Me' request callback
			if (user != null)
				Console.WriteLine ("GOT USER: " + user.Name);
			else
				Console.WriteLine ("Failed to get 'me'!");
		}

		private void fbLoginClickHandler() {
			StartActivity(typeof(StartScreenActivity));
		}

	} //end class
} //end namespace
