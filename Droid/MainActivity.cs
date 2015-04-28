using System;
using System.Net.Http;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin;
using Xamarin.Facebook;
using Xamarin.Facebook.Model;
using Xamarin.Facebook.Widget;
using Microsoft.WindowsAzure.MobileServices;
using Com.Telerik.Widget.Chart;
using Com.Telerik;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart;


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
			SetContentView (Resource.Layout.Login);

			//Connect to Azure
			try {
				Azure.InitializeAzure ();
				//System.Threading.Thread.Sleep(1000);
			} catch( Exception e) {
				Console.WriteLine(e);
			}
				

			//If Facebook session is already open from a previous login, request user info
			if (Session.ActiveSession != null && Session.ActiveSession.IsOpened) {
				//Get user info from Facebook
				Console.WriteLine("Fetching user information from open Facebook session");
				Request.NewMeRequest (Session.ActiveSession, this).ExecuteAsync ();
				Console.WriteLine ("Successfully fetched user information from Facebook");
				Console.WriteLine ("Attempting to get picture");
				new Request(Session.ActiveSession, "/me/picture", null, Xamarin.Facebook.HttpMethod.Get).ExecuteAsync();
			} 
		}//end OnCreate method

		//This method is required by Facebook SDK Request.IGraphUserCallback, handles callback from the Facebook button
		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			//Relay the result to the Facebook Session
			Session.ActiveSession.OnActivityResult (this, requestCode, (int)resultCode, data);

			//If a Facebook session is open, request the user's information an		
			if (Session.ActiveSession.IsOpened) {
				Request.NewMeRequest (Session.ActiveSession, this).ExecuteAsync ();
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
				Console.WriteLine ("Facebook user link = " + user.Link);

				//Get or create user account in Azure, get data
				try {
					Console.WriteLine("Fetching UserAccount from Azure");
					Console.WriteLine("Util.thisUser = " + Util.thisUser.firstName + " " + Util.thisUser.lastName);
					Azure.GetUserAccount (Util.thisUser);
					Console.WriteLine("Fetching Movements from Azure");
					Azure.GetMovements();
					Console.WriteLine("Fetching Workouts from Azure");
					Azure.GetWorkouts();
					Console.WriteLine("Fetching WorkoutSegments from Azure");
					Azure.GetWorkoutSegments();
					Azure.GetUserJournals(Util.thisUser);
				} catch (Exception e) {
					Console.WriteLine (e);
				}

				//Start a new Activity for the Main layout
				StartActivity (typeof(StartScreenActivity));
			}
		}//end OnCompleted method
	}	//end class
} //end namespace
