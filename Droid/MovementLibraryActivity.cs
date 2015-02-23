
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
using Google.YouTube.Player;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "MovementLibraryActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class MovementLibraryActivity : YouTubeFailureRecoveryActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//Show the MovementLibrary layout
			SetContentView (Resource.Layout.MovementLibrary);

			YouTubePlayerView playerView = FindViewById<YouTubePlayerView>(Resource.Id.hangPowerCleanVideoView);
			playerView.Initialize (DeveloperKey.key, this);

			//TODO: Get URIs from local file/azure source

			Button hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click += goToHomeScreen;
		}

		protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()
		{
			return FindViewById<YouTubePlayerView> (Resource.Id.hangPowerCleanVideoView);
		}

		public override void OnInitializationSuccess (IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored)
		{
			if (!wasRestored) {
				player.CueVideo("FfcU7GIboKI"); }
			player.
		}

		void goToUserProfile(object sender, EventArgs e) {
			//Start a new Activity for the UserProfile layout
			StartActivity (typeof(UserProfileActivity));
		}

		void goToHomeScreen(object sender, EventArgs e) {
			//Start a new Activity for the Main layout
			StartActivity (typeof(StartScreenActivity));
		}

		void goToMovementLibrary(object sender, EventArgs e) {
			//Start a new Activity for the MovementLibrary layout
			StartActivity(typeof(MovementLibraryActivity));
		}
	}
}

