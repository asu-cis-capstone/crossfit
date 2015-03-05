package mono.com.facebook.widget;


public class LikeView_OnErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.LikeView.OnErrorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Landroid/os/Bundle;)V:GetOnError_Landroid_os_Bundle_Handler:Xamarin.Facebook.Widget.LikeView/IOnErrorListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.LikeView/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LikeView_OnErrorListenerImplementor.class, __md_methods);
	}


	public LikeView_OnErrorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LikeView_OnErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.LikeView/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (android.os.Bundle p0)
	{
		n_onError (p0);
	}

	private native void n_onError (android.os.Bundle p0);

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
