package mono.com.google.android.youtube.player;


public class YouTubePlayer_OnFullscreenListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubePlayer.OnFullscreenListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onFullscreen:(Z)V:GetOnFullscreen_ZHandler:Google.YouTube.Player.IYouTubePlayerOnFullscreenListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("Google.YouTube.Player.IYouTubePlayerOnFullscreenListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubePlayer_OnFullscreenListenerImplementor.class, __md_methods);
	}


	public YouTubePlayer_OnFullscreenListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubePlayer_OnFullscreenListenerImplementor.class)
			mono.android.TypeManager.Activate ("Google.YouTube.Player.IYouTubePlayerOnFullscreenListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFullscreen (boolean p0)
	{
		n_onFullscreen (p0);
	}

	private native void n_onFullscreen (boolean p0);

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
