
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
		public Boolean firstPlayer=false;
		public Boolean secondPlayer=false;
		public Boolean thirdPlayer=false;
		public Boolean fourthPlayer=false;
		public Boolean fifthPlayer=false;
		public Boolean sixthPlayer=false;
		public Boolean seventhPlayer=false;
		public Boolean eighthPlayer=false;
		public Boolean ninthPlayer=false;
		public Boolean tenthPlayer=false;

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
		//	YouTubePlayerFragment youtubePlayer9 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer9);
		//		youtubePlayer9.Initialize (DeveloperKey.key, this);
			YouTubePlayerFragment youtubePlayer10 = (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer10);
				youtubePlayer10.Initialize (DeveloperKey.key, this);

			Button hamburgerButton = FindViewById<Button> (Resource.Id.hamburgerButton);
			hamburgerButton.Click += goToHomeScreen;
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
			} else if (!sixthPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer6);
			} else if (!seventhPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer7);
			} else if (!eighthPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer8);
			} else if (!ninthPlayer) {
	//			return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer9);
			} else if (!tenthPlayer) {
				return (YouTubePlayerFragment) FragmentManager.FindFragmentById (Resource.Id.youtubePlayer10);
			}

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
			} else if (!fifthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+4], 50);
				fifthPlayer=true;
			} else if (!sixthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+5], 50);
				sixthPlayer=true;
			} else if (!seventhPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+6], 50);
				seventhPlayer=true;
			} else if (!eighthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+7], 50);
				eighthPlayer=true;
			} else if (!ninthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+8], 50);
				ninthPlayer=true;
			} else if (!tenthPlayer) {
				player.CueVideo (MovementLinks.MovementUrls[startIndex+9], 50);
				tenthPlayer=true;
			} 
		}

		private void resetBools() {
			firstPlayer=false;
			secondPlayer=false;
			thirdPlayer=false;
			fourthPlayer=false;
			fifthPlayer=false;
			sixthPlayer=false;
			seventhPlayer=false;
			eighthPlayer=false;
			ninthPlayer=false;
			tenthPlayer=false;
		}

	} //End class
} //End namespace

