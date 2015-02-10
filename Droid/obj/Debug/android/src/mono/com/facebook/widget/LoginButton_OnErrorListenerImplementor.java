package mono.com.facebook.widget;


public class LoginButton_OnErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.LoginButton.OnErrorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/facebook/FacebookException;)V:GetOnError_Lcom_facebook_FacebookException_Handler:Xamarin.Facebook.Widget.LoginButton/IOnErrorListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.LoginButton/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LoginButton_OnErrorListenerImplementor.class, __md_methods);
	}


	public LoginButton_OnErrorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LoginButton_OnErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.LoginButton/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (com.facebook.FacebookException p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.facebook.FacebookException p0);

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
