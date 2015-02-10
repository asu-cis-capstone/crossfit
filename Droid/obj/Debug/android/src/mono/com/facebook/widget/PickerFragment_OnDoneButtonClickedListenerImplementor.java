package mono.com.facebook.widget;


public class PickerFragment_OnDoneButtonClickedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.PickerFragment.OnDoneButtonClickedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDoneButtonClicked:(Lcom/facebook/widget/PickerFragment;)V:GetOnDoneButtonClicked_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.Facebook.Widget.PickerFragment/IOnDoneButtonClickedListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.PickerFragment/IOnDoneButtonClickedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PickerFragment_OnDoneButtonClickedListenerImplementor.class, __md_methods);
	}


	public PickerFragment_OnDoneButtonClickedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PickerFragment_OnDoneButtonClickedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.PickerFragment/IOnDoneButtonClickedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDoneButtonClicked (com.facebook.widget.PickerFragment p0)
	{
		n_onDoneButtonClicked (p0);
	}

	private native void n_onDoneButtonClicked (com.facebook.widget.PickerFragment p0);

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
