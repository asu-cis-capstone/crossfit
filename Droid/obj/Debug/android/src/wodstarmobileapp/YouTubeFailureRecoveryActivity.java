package wodstarmobileapp;


public abstract class YouTubeFailureRecoveryActivity
	extends com.google.android.youtube.player.YouTubeBaseActivity
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubePlayer.OnInitializedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onInitializationFailure:(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V:GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings\n" +
			"n_onInitializationSuccess:(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubePlayer;Z)V:GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_ZHandler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("WodstarMobileApp.YouTubeFailureRecoveryActivity, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubeFailureRecoveryActivity.class, __md_methods);
	}


	public YouTubeFailureRecoveryActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubeFailureRecoveryActivity.class)
			mono.android.TypeManager.Activate ("WodstarMobileApp.YouTubeFailureRecoveryActivity, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onInitializationFailure (com.google.android.youtube.player.YouTubePlayer.Provider p0, com.google.android.youtube.player.YouTubeInitializationResult p1)
	{
		n_onInitializationFailure (p0, p1);
	}

	private native void n_onInitializationFailure (com.google.android.youtube.player.YouTubePlayer.Provider p0, com.google.android.youtube.player.YouTubeInitializationResult p1);


	public void onInitializationSuccess (com.google.android.youtube.player.YouTubePlayer.Provider p0, com.google.android.youtube.player.YouTubePlayer p1, boolean p2)
	{
		n_onInitializationSuccess (p0, p1, p2);
	}

	private native void n_onInitializationSuccess (com.google.android.youtube.player.YouTubePlayer.Provider p0, com.google.android.youtube.player.YouTubePlayer p1, boolean p2);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
