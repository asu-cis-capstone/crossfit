package mono.com.facebook.android;


public class Facebook_ServiceListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.android.Facebook.ServiceListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onComplete:(Landroid/os/Bundle;)V:GetOnComplete_Landroid_os_Bundle_Handler:Xamarin.Facebook.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook\n" +
			"n_onError:(Ljava/lang/Error;)V:GetOnError_Ljava_lang_Error_Handler:Xamarin.Facebook.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook\n" +
			"n_onFacebookError:(Lcom/facebook/android/FacebookError;)V:GetOnFacebookError_Lcom_facebook_android_FacebookError_Handler:Xamarin.Facebook.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.XAndroid.Facebook/IServiceListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Facebook_ServiceListenerImplementor.class, __md_methods);
	}


	public Facebook_ServiceListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Facebook_ServiceListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.XAndroid.Facebook/IServiceListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onComplete (android.os.Bundle p0)
	{
		n_onComplete (p0);
	}

	private native void n_onComplete (android.os.Bundle p0);


	public void onError (java.lang.Error p0)
	{
		n_onError (p0);
	}

	private native void n_onError (java.lang.Error p0);


	public void onFacebookError (com.facebook.android.FacebookError p0)
	{
		n_onFacebookError (p0);
	}

	private native void n_onFacebookError (com.facebook.android.FacebookError p0);

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
