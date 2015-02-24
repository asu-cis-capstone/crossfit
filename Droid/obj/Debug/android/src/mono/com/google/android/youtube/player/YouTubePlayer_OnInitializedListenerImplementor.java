package mono.com.google.android.youtube.player;


public class YouTubePlayer_OnInitializedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubePlayer.OnInitializedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onInitializationFailure:(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V:GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings\n" +
			"n_onInitializationSuccess:(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubePlayer;Z)V:GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_ZHandler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("Google.YouTube.Player.IYouTubePlayerOnInitializedListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubePlayer_OnInitializedListenerImplementor.class, __md_methods);
	}


	public YouTubePlayer_OnInitializedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubePlayer_OnInitializedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Google.YouTube.Player.IYouTubePlayerOnInitializedListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


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
