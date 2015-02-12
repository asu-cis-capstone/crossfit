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
	public class MainActivity : Activity
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
		}

		private void fbLoginClickHandler() {
			StartActivity(typeof(StartScreenActivity));
		}

	} //end class
} //end namespace
