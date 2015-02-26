
using System;
using Android.App;
using Android.OS;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Runtime;
using Android.Widget;
using Google.YouTube.Player;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "MovementLibraryActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class MovementLibraryActivity : YouTubeFailureRecoveryActivity
	{
		public int startIndex;
		public Boolean firstPlayer=false;
		public Boolean secondPlayer=false;
		public Boolean thirdPlayer=false;
		public Boolean fourthPlayer=false;
		public Boolean fifthPlayer=false;

		protected override void OnCreate (Bundle bundle)
		{
			resetBools ();
			startIndex = 0;

			base.OnCreate (bundle);
			//Show the MovementLibrary layout
			SetContentView (Resource.Layout.MovementLibrary);

			YouTubePlayerFragment youtubePlayer1 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);
				youtubePlayer1.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer2 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer2);
				youtubePlayer2.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer3 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer3);
				youtubePlayer3.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer4 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer4);
				youtubePlayer4.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer5 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer5);
				youtubePlayer5.Initialize (DeveloperKey.key, this);

			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			Button hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};
		}

		protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()
		{
			if (!firstPlayer) {
				return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);
			} else if (!secondPlayer) {
				return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer2);
			} else if (!thirdPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer3);
			} else if (!fourthPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer4);
			} else if (!fifthPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer5);
			}
			return (YouTubePlayerFragment)FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);
		}

		public override void OnInitializationSuccess (IYouTubePlayerProvider provider, IYouTubePlayer player, bool wasRestored)
		{
			if (!wasRestored) {
				loadVideos(player);
			} 
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

		private void loadVideos(IYouTubePlayer player) {
			if (!firstPlayer) {
				player.CueVideo (MovementLinks.MovementUrls [startIndex], 50);
				firstPlayer = true;
			} else if (!secondPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+1], 50);
				secondPlayer=true;
			} else if (!thirdPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+2], 50);
				thirdPlayer=true;
			} else if (!fourthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+3], 50);
				fourthPlayer=true;
			} else {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+4], 50);
				fifthPlayer=true;
			} 
		}

		private void resetBools() {
			firstPlayer=false;
			secondPlayer=false;
			thirdPlayer=false;
			fourthPlayer=false;
			fifthPlayer=false;
		}

	} //End class
} //End namespace

