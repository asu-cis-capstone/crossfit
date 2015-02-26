package mono.com.facebook.widget;


public class PickerFragment_OnErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.PickerFragment.OnErrorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/facebook/widget/PickerFragment;Lcom/facebook/FacebookException;)V:GetOnError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_Handler:Xamarin.Facebook.Widget.PickerFragment/IOnErrorListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.PickerFragment/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PickerFragment_OnErrorListenerImplementor.class, __md_methods);
	}


	public PickerFragment_OnErrorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PickerFragment_OnErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.PickerFragment/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (com.facebook.widget.PickerFragment p0, com.facebook.FacebookException p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (com.facebook.widget.PickerFragment p0, com.facebook.FacebookException p1);

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
