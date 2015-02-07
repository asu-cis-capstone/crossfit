using System;
using System.Threading;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//Create splash screen activity as the MainLauncher, then call MainActivity
namespace WodstarMobileApp.Droid
{
	[Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, Label = "Wodstar", Icon = "@drawable/icon")]
	public class SplashActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//start the main activity
			StartActivity(typeof(MainActivity));
		}
	}
}

