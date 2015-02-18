package mono.com.facebook.widget;


public class PickerFragment_OnDataChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.PickerFragment.OnDataChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDataChanged:(Lcom/facebook/widget/PickerFragment;)V:GetOnDataChanged_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.Facebook.Widget.PickerFragment/IOnDataChangedListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.PickerFragment/IOnDataChangedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PickerFragment_OnDataChangedListenerImplementor.class, __md_methods);
	}


	public PickerFragment_OnDataChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PickerFragment_OnDataChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.PickerFragment/IOnDataChangedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDataChanged (com.facebook.widget.PickerFragment p0)
	{
		n_onDataChanged (p0);
	}

	private native void n_onDataChanged (com.facebook.widget.PickerFragment p0);

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
