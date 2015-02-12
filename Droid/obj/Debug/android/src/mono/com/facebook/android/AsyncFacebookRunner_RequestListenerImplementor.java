package mono.com.facebook.android;


public class AsyncFacebookRunner_RequestListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.android.AsyncFacebookRunner.RequestListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onComplete:(Ljava/lang/String;Ljava/lang/Object;)V:GetOnComplete_Ljava_lang_String_Ljava_lang_Object_Handler:Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook\n" +
			"n_onFacebookError:(Lcom/facebook/android/FacebookError;Ljava/lang/Object;)V:GetOnFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_Handler:Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook\n" +
			"n_onFileNotFoundException:(Ljava/io/FileNotFoundException;Ljava/lang/Object;)V:GetOnFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_Handler:Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook\n" +
			"n_onIOException:(Ljava/io/IOException;Ljava/lang/Object;)V:GetOnIOException_Ljava_io_IOException_Ljava_lang_Object_Handler:Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook\n" +
			"n_onMalformedURLException:(Ljava/net/MalformedURLException;Ljava/lang/Object;)V:GetOnMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_Handler:Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AsyncFacebookRunner_RequestListenerImplementor.class, __md_methods);
	}


	public AsyncFacebookRunner_RequestListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AsyncFacebookRunner_RequestListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.XAndroid.AsyncFacebookRunner/IRequestListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onComplete (java.lang.String p0, java.lang.Object p1)
	{
		n_onComplete (p0, p1);
	}

	private native void n_onComplete (java.lang.String p0, java.lang.Object p1);


	public void onFacebookError (com.facebook.android.FacebookError p0, java.lang.Object p1)
	{
		n_onFacebookError (p0, p1);
	}

	private native void n_onFacebookError (com.facebook.android.FacebookError p0, java.lang.Object p1);


	public void onFileNotFoundException (java.io.FileNotFoundException p0, java.lang.Object p1)
	{
		n_onFileNotFoundException (p0, p1);
	}

	private native void n_onFileNotFoundException (java.io.FileNotFoundException p0, java.lang.Object p1);


	public void onIOException (java.io.IOException p0, java.lang.Object p1)
	{
		n_onIOException (p0, p1);
	}

	private native void n_onIOException (java.io.IOException p0, java.lang.Object p1);


	public void onMalformedURLException (java.net.MalformedURLException p0, java.lang.Object p1)
	{
		n_onMalformedURLException (p0, p1);
	}

	private native void n_onMalformedURLException (java.net.MalformedURLException p0, java.lang.Object p1);

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
