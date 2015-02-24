
using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Google.YouTube.Player;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "MovementLibraryActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class MovementLibraryActivity : YouTubeFailureRecoveryActivity
	{
		public int startIndex;
		Boolean firstPlayer=false;
		Boolean secondPlayer=false;
		Boolean thirdPlayer=false;
		Boolean fourthPlayer=false;
		Boolean fifthPlayer=false;
		Boolean sixthPlayer=false;
		Boolean seventhPlayer=false;
		Boolean eighthPlayer=false;
		Boolean ninthPlayer=false;
		Boolean tenthPlayer=false;

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
			YouTubePlayerFragment youtubePlayer6 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer6);
				youtubePlayer6.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer7 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer7);
				youtubePlayer7.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer8 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer8);
				youtubePlayer8.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer9 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer9);
				youtubePlayer9.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer10 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer10);
				youtubePlayer10.Initialize (DeveloperKey.key, this);

			Button hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click += goToHomeScreen;
		}

		protected override IYouTubePlayerProvider GetYouTubePlayerProvider ()
		{
		
			return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer1);	
			return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer2);	
			return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer3);
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
			if (!firstVideo) {
				player.CueVideo (MovementLinks.MovementUrls [startIndex], 50);
				firstVideo = true;
			} else if (!secondVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+1] 50);
				secondVideo=true;
			} else if (!thirdVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+2], 50);
				thirdVideo=true;
			} else if (!fourthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+3], 50);
				fourthVideo=true;
			} else if (!fifthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+4], 50);
				fifthVideo=true;
			} else if (!sixthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+5], 50);
				sixthVideo=true;
			} else if (!seventhVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+6], 50);
				seventhVideo=true;
			} else if (!eighthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+7], 50);
				eighthVideo=true;
			} else if (!ninthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+8], 50);
				ninthVideo=true;
			} else if (!tenthVideo) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+9], 50);
				tenthVideo=true;
			} 
		}

		private void resetBools() {
			Boolean firstPlayer=false;
			Boolean secondPlayer=false;
			Boolean thirdPlayer=false;
			Boolean fourthPlayer=false;
			Boolean fifthPlayer=false;
			Boolean sixthPlayer=false;
			Boolean seventhPlayer=false;
			Boolean eighthPlayer=false;
			Boolean ninthPlayer=false;
			Boolean tenthPlayer=false;
		}

	} //End class
} //End namespace

