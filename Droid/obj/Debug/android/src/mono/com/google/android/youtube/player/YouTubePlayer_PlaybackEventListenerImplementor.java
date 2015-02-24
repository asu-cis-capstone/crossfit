package mono.com.google.android.youtube.player;


public class YouTubePlayer_PlaybackEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubePlayer.PlaybackEventListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onBuffering:(Z)V:GetOnBuffering_ZHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onPaused:()V:GetOnPausedHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onPlaying:()V:GetOnPlayingHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onSeekTo:(I)V:GetOnSeekTo_IHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onStopped:()V:GetOnStoppedHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubePlayer_PlaybackEventListenerImplementor.class, __md_methods);
	}


	public YouTubePlayer_PlaybackEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubePlayer_PlaybackEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBuffering (boolean p0)
	{
		n_onBuffering (p0);
	}

	private native void n_onBuffering (boolean p0);


	public void onPaused ()
	{
		n_onPaused ();
	}

	private native void n_onPaused ();


	public void onPlaying ()
	{
		n_onPlaying ();
	}

	private native void n_onPlaying ();


	public void onSeekTo (int p0)
	{
		n_onSeekTo (p0);
	}

	private native void n_onSeekTo (int p0);


	public void onStopped ()
	{
		n_onStopped ();
	}

	private native void n_onStopped ();

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
