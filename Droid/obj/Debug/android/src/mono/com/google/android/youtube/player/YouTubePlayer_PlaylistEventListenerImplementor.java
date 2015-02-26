package mono.com.google.android.youtube.player;


public class YouTubePlayer_PlaylistEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubePlayer.PlaylistEventListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onNext:()V:GetOnNextHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onPlaylistEnded:()V:GetOnPlaylistEndedHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings\n" +
			"n_onPrevious:()V:GetOnPreviousHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubePlayer_PlaylistEventListenerImplementor.class, __md_methods);
	}


	public YouTubePlayer_PlaylistEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubePlayer_PlaylistEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onNext ()
	{
		n_onNext ();
	}

	private native void n_onNext ();


	public void onPlaylistEnded ()
	{
		n_onPlaylistEnded ();
	}

	private native void n_onPlaylistEnded ();


	public void onPrevious ()
	{
		n_onPrevious ();
	}

	private native void n_onPrevious ();

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
