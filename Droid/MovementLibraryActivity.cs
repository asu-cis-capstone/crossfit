
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.App;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "MovementLibraryActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]			
	public class MovementLibraryActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.MovementLibrary);

			//TODO: Get URIs from local file/azure source
			var hangPowerCleanVideoView = FindViewById<VideoView> (Resource.Id.hangPowerCleanVideoView);
			MediaController mc = new Android.Widget.MediaController (this);
			mc.SetAnchorView (hangPowerCleanVideoView);
			mc.SetMediaPlayer (hangPowerCleanVideoView);
			hangPowerCleanVideoView.SetMediaController (mc);
			var hangPowerCleanUri = Android.Net.Uri.Parse ("https://www.youtube.com/embed/FfcU7GIboKI");
			hangPowerCleanVideoView.SetVideoURI (hangPowerCleanUri);
			hangPowerCleanVideoView.Start ();

			var burpeeVideoView = FindViewById<VideoView> (Resource.Id.burpeeVideoView);
		}
	}
}

