package mono.com.facebook.widget;


public class PickerFragment_OnSelectionChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.PickerFragment.OnSelectionChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSelectionChanged:(Lcom/facebook/widget/PickerFragment;)V:GetOnSelectionChanged_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.Facebook.Widget.PickerFragment/IOnSelectionChangedListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Widget.PickerFragment/IOnSelectionChangedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PickerFragment_OnSelectionChangedListenerImplementor.class, __md_methods);
	}


	public PickerFragment_OnSelectionChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PickerFragment_OnSelectionChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Widget.PickerFragment/IOnSelectionChangedListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSelectionChanged (com.facebook.widget.PickerFragment p0)
	{
		n_onSelectionChanged (p0);
	}

	private native void n_onSelectionChanged (com.facebook.widget.PickerFragment p0);

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
