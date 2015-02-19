package mono.com.google.android.youtube.player;


public class YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.youtube.player.YouTubeThumbnailLoader.OnThumbnailLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onThumbnailError:(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;)V:GetOnThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_Handler:Google.YouTube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker, YoutubeJavaBindings\n" +
			"n_onThumbnailLoaded:(Lcom/google/android/youtube/player/YouTubeThumbnailView;Ljava/lang/String;)V:GetOnThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker, YoutubeJavaBindings\n" +
			"";
		mono.android.Runtime.register ("Google.YouTube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor.class, __md_methods);
	}


	public YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Google.YouTube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerImplementor, YoutubeJavaBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onThumbnailError (com.google.android.youtube.player.YouTubeThumbnailView p0, com.google.android.youtube.player.YouTubeThumbnailLoader.ErrorReason p1)
	{
		n_onThumbnailError (p0, p1);
	}

	private native void n_onThumbnailError (com.google.android.youtube.player.YouTubeThumbnailView p0, com.google.android.youtube.player.YouTubeThumbnailLoader.ErrorReason p1);


	public void onThumbnailLoaded (com.google.android.youtube.player.YouTubeThumbnailView p0, java.lang.String p1)
	{
		n_onThumbnailLoaded (p0, p1);
	}

	private native void n_onThumbnailLoaded (com.google.android.youtube.player.YouTubeThumbnailView p0, java.lang.String p1);

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
